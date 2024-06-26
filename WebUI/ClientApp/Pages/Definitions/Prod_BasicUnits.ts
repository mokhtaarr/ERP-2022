﻿$(document).ready(() => {
    SharedButtons.OnLoad();
    ProdBasicUnits.InitalizeComponent();
    $('#headertop1').addClass('display_none');
    $('#headertop2').removeClass('display_none');
})
 
namespace ProdBasicUnits {
    var sys: SystemTools = new SystemTools();
    var language = sys.SysSession.CurrentEnvironment.ScreenLanguage;
    var SysSession: SystemSession = GetSystemSession();
    let Resource: any = GetResourceList("");
    $('#headerTitle').text(Resource.BasicUnits);

    var UnitsGrid: JsGrid = new JsGrid();
    var UnitsDetailsGrid: JsGrid = new JsGrid();

    var BasicUnitsDetailesVM: Prod_BasicUnitsDetailesVM = new Prod_BasicUnitsDetailesVM();
    var Model: Prod_BasicUnits = new Prod_BasicUnits();
    var BasicUnits: Array<Prod_BasicUnits> = new Array<Prod_BasicUnits>();

    var Details: Array<Prod_BasicUnits> = new Array<Prod_BasicUnits>();
    var DetailsPros: Array<Prod_BasicUnits> = new Array<Prod_BasicUnits>();
    var Data = new Array();

    var element: HTMLInputElement;
    // Select Option

    var nodeActive: any;
    var StatusFlag;
    var Success;
    var hasNodes: boolean;
    var ObjectId = 0;
    var trId: string;

    export function InitalizeComponent() {
        SharedButtons.compcode = Number(SysSession.CurrentEnvironment.CompCode);

        SharedWork.withCondition = true;
        localStorage.setItem("TableName", "Prod_BasicUnits");
        localStorage.setItem("Condition", "ParentUnit is null");

        NavigateModule.InitalizeComponent();
        SharedWork.OnNavigate = Navigate;
        SharedButtons.AddAction(() => { btnAdd_onclick(); });

        SharedButtons.DeleteAction(() => { btnDelete_onClick(); });

        SharedButtons.EditAction(() => { btnEdit_onclick(); });

        SharedButtons.UndoAction(() => { Undo(); });

        SharedButtons.SaveAction(() => {
            if (SharedWork.CurrentMode == ScreenModes.Add || SharedWork.CurrentMode == ScreenModes.Edit) {
                btnsave_onClick();
            }
            else if (SharedWork.CurrentMode == ScreenModes.Query) {
                WorningMessage("يجب اختيار وضع التعديل او الاضافة اولا ", "Please Select Save Or Edit Mode First");
                return;
            }
        });

        InitalizeControls();
        InitalizeEvents();
        GetAll();

        InitializeGrid();
        InitializeBasicUnitDetailsGrid();
    }

    function InitalizeControls() {
        SharedButtons.btnSearch = document.getElementById("btnProd_BasicUnitsSearch") as HTMLButtonElement;
    }

    function InitalizeEvents() {
        SharedButtons.btnSearch.onclick = btnSearch_onclick;
        SharedButtons.btnRefrash2.onclick = Refrash;
    }

    function GetAll() {
        Disabled(false);
        Ajax.Callsync({
            type: "Get",
            url: sys.apiUrl("Prod_BasicUnits", "GetAll"),
            success: (d) => {
                let result = d as BaseResponse;
                if (result.IsSuccess) {
                    Data = new Array();
                    BasicUnits = result.Response as Array<Prod_BasicUnits>;
                    UnitsGrid.DataSource = BasicUnits;
                    UnitsGrid.Bind();
                }
            }
        });
    }

    ///////////////////////////////////// Strt Grid /////////////////////////////////
    function InitializeGrid() {
        UnitsGrid.ElementName = "UnitsGrid";
        UnitsGrid.PrimaryKey = "BasUnitId";
        UnitsGrid.InsertionMode = JsGridInsertionMode.Binding;
        UnitsGrid.Paging = true;
        UnitsGrid.PageSize = 5;
        UnitsGrid.OnItemInserting = () => { };
        UnitsGrid.OnItemUpdating = () => { };
        UnitsGrid.OnItemDeleting = () => { };
        UnitsGrid.OnRowDoubleClicked = () => { GetByID(Number(UnitsGrid.SelectedKey)); };
        UnitsGrid.Columns = [
            {
                title: Resource.SHT_Code, css: "ColumPadding", name: "UnitCode"
            },
            {
                title: Resource.Name_Arabic, css: "ColumPadding", name: "UnitNam"
            },
            {
                title: Resource.Name_English, css: "ColumPadding", name: "UnitNameE"
            },
            {
                title: Resource.GroupDescription, css: "ColumPadding", name: "AutoDesc"
            },
            {
                title: Resource.ConversionFactor, css: "ColumPadding", name: "UnittRate"
            },
            {
                title: Resource.Symbol, css: "ColumPadding", name: "Symbol"
            },
            {
                title: Resource.Using, css: "ColumPadding", name: "Remarks"
            },
        ];
        UnitsGrid.Bind();
    }

    function FillGrid(BasicUnitsDetailes: Prod_BasicUnitsDetailesVM) {
        try {
            Details = BasicUnitsDetailes.Details;
            UnitsDetailsGrid.DataSource = Details;
            UnitsDetailsGrid.Bind();
        } catch (e) { }
    }

    function InitializeBasicUnitDetailsGrid() {
        UnitsDetailsGrid.ElementName = "UnitsDetailsGrid";
        UnitsDetailsGrid.PrimaryKey = "AlterId";
        UnitsDetailsGrid.Inserting = true;
        UnitsDetailsGrid.Editing = true;
        UnitsDetailsGrid.Paging = true;
        UnitsDetailsGrid.PageSize = 10;
        UnitsDetailsGrid.ConfirmDeleteing = true;
        UnitsDetailsGrid.InsertionMode = JsGridInsertionMode.Binding;
        UnitsDetailsGrid.OnItemEditing = () => { trId = "_idEdit"; };

        UnitsDetailsGrid.OnItemInserting = InsertItemAlternatives;
        UnitsDetailsGrid.OnItemUpdating = UpdateItemAlternatives
        UnitsDetailsGrid.OnItemDeleting = DeleteItemAlternatives;

        UnitsDetailsGrid.OnRowSelected = () => { };
        UnitsDetailsGrid.OnRefreshed = () => { };
        UnitsDetailsGrid.Columns = [
            {
                title: "#", name: "btnAddItem", visible: true, type: "control", modeSwitchButton: true, editButton: true
            },
            {
                title: Resource.SHT_Code, css: "ColumPadding", name: "UnitCode", id: "UnitCode", type: "text"
            },
            {
                title: Resource.Name_Arabic, css: "ColumPadding", name: "UnitNam", id: "UnitNam", type: "text"
            },
            {
                title: Resource.Name_English + " 2", css: "ColumPadding", name: "UnitNameE", id: "UnitNameE", type: "text"
            },
            {
                title: Resource.ConversionFactor, css: "ColumPadding", name: "UnittRate", id: "UnittRate", type: "number"
            },
            {
                title: Resource.Symbol, css: "ColumPadding", name: "Symbol", id: "Symbol", type: "text"
            },
            {
                title: Resource.Notes, css: "ColumPadding", name: "Remarks", id: "Remarks", type: "text"
            },

            /////////////////////////////////// hiden fileds ////////////////////////////
            {
                title: "ParentUnit", css: "ColumPadding disable hidden", name: "ParentUnit", id: "ParentUnit", type: "text"
            },
            {
                title: "StatusFlag", css: "ColumPadding disable hidden", name: "StatusFlag", id: "StatusFlag", type: "text"
            },
        ];
        UnitsDetailsGrid.Bind();
    }

    function InsertItemAlternatives(e: JsGridInsertEventArgs) {
        let item = e.Item as Prod_BasicUnits;
        item.StatusFlag = 'i';

        Details.push(item);
        UnitsDetailsGrid.DataSource = Details;
        UnitsDetailsGrid.Bind();
    }

    function UpdateItemAlternatives(e: JsGridUpdateEventArgs) {
        let item = e.Item as Prod_BasicUnits;
        item.StatusFlag = 'u';

        var index: number = e.ItemIndex;
        Details.splice(index, 1, item);

        UnitsDetailsGrid.DataSource = Details;
        UnitsDetailsGrid.Bind();

        DetailsPros.push(item);
    }

    function DeleteItemAlternatives(e: JsGridDeleteEventArgs) {
        let item = e.Item as Prod_BasicUnits;
        var index: number = e.ItemIndex;
        item.StatusFlag = 'd';

        DetailsPros.push(item);
        Details.splice(index, 1);
    }
    ///////////////////////////////////// End Grid /////////////////////////////////

    function GetByID(Id) {
        Ajax.Callsync({
            type: "Get",
            url: sys.apiUrl("Prod_BasicUnits", "GetById"),
            data: { id: Id },
            success: (d) => {
                let result = d as BaseResponse;
                if (result.IsSuccess) {
                    BasicUnitsDetailesVM = result.Response as Prod_BasicUnitsDetailesVM;

                    Display(BasicUnitsDetailesVM.Model);
                    FillGrid(BasicUnitsDetailesVM);
                    SharedWork.SwitchModes(ScreenModes.Query);
                }
                else
                    MessageBox.Toastr(result.ErrorMessage, Resource.Error, ToastrTypes.error);
            }
        });
    }

    function Display(model: Prod_BasicUnits) {
        DocumentActions.RenderFromModel(model);
        ObjectId = Number(model.BasUnitId);
        Model = model;
    }

    function Navigate() {
        Model = BasicUnits[SharedWork.PageIndex - 1];
        GetByID(Model.BasUnitId);
    }

    function btnAdd_onclick() {
        RemoveDisabled(true);
        element = DocumentActions.GetElementByName("UnittRate");
        element.disabled = true;
        element.value = "1.000";

        ClearGrids();
        StatusFlag = 'i';
    }

    function btnEdit_onclick() {
        if (ObjectId == 0) {
            MessageBox.Show(Resource.PleaseSelectItem, Resource.Error);
        }
        else {
            RemoveDisabled(false);
            element = DocumentActions.GetElementByName("UnitCode");
            element.disabled = true;

            element = DocumentActions.GetElementByName("UnittRate");
            element.disabled = true;

            StatusFlag = 'u';
        }
    }

    function btnsave_onClick() {
        if (!ValidationHeader()) return
        Save();
    }

    function btnDelete_onClick() {
        Delete()
    }

    function ValidationHeader() {
        if (DocumentActions.GetElementByName("UnitCode").value == "") {
            MessageBox.Toastr(Resource.PleaseEnterCode, Resource.Error, ToastrTypes.error);
            return false
        }
        else if (DocumentActions.CheckCode(BasicUnits, DocumentActions.GetElementByName("UnitCode").value, "UnitCode") == false && StatusFlag == "i") {
            MessageBox.Toastr(Resource.CodeCannotDuplicated, Resource.Error, ToastrTypes.error);
        }
        else if (DocumentActions.GetElementByName("UnitNam").value == "") {
            MessageBox.Toastr(Resource.PleaseEnterNameArabic, Resource.Error, ToastrTypes.error);
            return false
        }
        else
            return true;
    }

    function RemoveDisabled(clear: boolean) {
        DocumentActions.allElements(false, clear, Model);
    }

    function Disabled(clear: boolean) {
        DocumentActions.allElements(true, clear, Model);
    }

    function Undo() {
        Disabled(false);
        Success = false;
        if (ObjectId != 0)
            GetByID(ObjectId);
        else
            SharedWork.SwitchModes(ScreenModes.Start);
        DetailsPros = new Array<Prod_BasicUnits>();
    }

    function Assign() {
        BasicUnitsDetailesVM.Model = DocumentActions.AssignToModel<Prod_BasicUnits>(Model);
        BasicUnitsDetailesVM.Details = DocumentActions.AssignArr(Details, DetailsPros);

        if (StatusFlag == "i") {
            Model.CreatedAt = DateTimeFormat(Date().toString());
            Model.CreatedBy = SysSession.CurrentEnvironment.UserCode;
            Insert();
        }
        if (StatusFlag == "u") {
            Model.BasUnitId = ObjectId;
            Model.UpdateAt = DateTimeFormat(Date().toString());
            Model.UpdateBy = SysSession.CurrentEnvironment.UserCode;
            Update();
        }

        if (Success)
            MessageBox.Toastr(Resource.SavedSucc, "", ToastrTypes.success);

        ObjectId = Model.BasUnitId;
        GetAll();
        if (ObjectId != 0)
            GetByID(ObjectId);

        return true;
    }

    function Insert() {
        $("#MessageBoxDialog").modal("hide");
        Ajax.Callsync({
            type: "POST",
            url: sys.apiUrl("Prod_BasicUnits", "Insert"),
            data: JSON.stringify(BasicUnitsDetailesVM),
            success: (Response) => {
                let result = Response as BaseResponse;
                if (result.IsSuccess) {
                    Model = result.Response as Prod_BasicUnits;
                    ObjectId = Model.BasUnitId;
                    Success = true;
                }
                else {
                    MessageBox.Toastr(result.ErrorMessage, Resource.Error, ToastrTypes.error);
                    Success = false;
                }
            }
        });
    }

    function Update() {
        $("#MessageBoxDialog").modal("hide");
        Ajax.Callsync({
            type: "POST",
            url: sys.apiUrl("Prod_BasicUnits", "Update"),
            data: JSON.stringify(BasicUnitsDetailesVM),
            success: (Response) => {
                let result = Response as BaseResponse;
                if (result.IsSuccess) {
                    Model = result.Response as Prod_BasicUnits;
                    ObjectId = Model.BasUnitId;
                    Success = true;
                }
                else {
                    MessageBox.Toastr(result.ErrorMessage, Resource.Error, ToastrTypes.error);
                    Success = false;
                }
            }
        });
    }

    function Save() {
        Assign();
        if (Success) {
            Disabled(false);
            Success = false;
            SharedWork.SwitchModes(ScreenModes.Query);
        }
    }

    function Delete() {
        $("#MessageBoxDialog").modal("hide");
        Ajax.Callsync({
            type: "Get",
            url: sys.apiUrl("Prod_BasicUnits", "Delete") + "/" + ObjectId,
            success: (result) => {
                if (result) {
                    Success = result;
                    GetAll();
                    Disabled(result);
                    ClearGrids();
                }
                else {
                    MessageBox.Toastr(Resource.DeletedErr, Resource.Error, ToastrTypes.error);
                    Success = false;
                }
            }
        });
    }

    function btnSearch_onclick() {
        let sys: SystemTools = new SystemTools();
        sys.FindKey(Modules.BasicUnits, SharedButtons.btnSearch.id, "", () => {
            if (Model.UnitCode != null) {
                Display(Model);
            }
        });
    }

    function Refrash() {
        GetAll();
        if (ObjectId != 0)
            GetByID(ObjectId);
    }

    function ClearGrids() {
        Details = new Array<Prod_BasicUnits>();
        UnitsDetailsGrid.DataSource = Details;
        UnitsDetailsGrid.Bind();
    }
}
