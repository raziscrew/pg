#pragma checksum "C:\Users\razis\Desktop\pg\Pages\IC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2014df20074c2b5f541b0d76d545f6f71e2398d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeAspNetCoreApp11.Pages.Pages_IC), @"mvc.1.0.razor-page", @"/Pages/IC.cshtml")]
namespace DevExtremeAspNetCoreApp11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\razis\Desktop\pg\Pages\_ViewImports.cshtml"
using DevExtremeAspNetCoreApp11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\razis\Desktop\pg\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
using JPGStockServer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2014df20074c2b5f541b0d76d545f6f71e2398d3", @"/Pages/IC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3c722c8ca4ea7adb42c4bf2994e5ab8875e8be", @"/Pages/_ViewImports.cshtml")]
    public class Pages_IC : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2014df20074c2b5f541b0d76d545f6f71e2398d33122", async() => {
                WriteLiteral("\r\n    <script defer src=\"/css/all.js\"></script> <!--load all styles -->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h2 class=\"content-block\">IC</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().DataGrid<Stock>()
    .ID("gridIC")
    .ElementAttr(new { @class = "dx-card wide-card" })
    // .Selection(s => s.Mode(SelectionMode.Single))
    .FocusedRowEnabled(true)
      // .FocusedRowIndex(0)
      .OnFocusedRowChanged("onFocusedRowChanged")
    // .OnContentReady(@<text> function(e) {if(!e.component.getSelectedRowKeys().length) e.component.selectRowsByIndexes(0);} </text>)
    .ShowBorders(false)
   // .ShowColumnLines(true)
   .RowAlternationEnabled(true)
   .FilterPanel(f => f.Visible(true))
    .FilterRow(f => f.Visible(true))
    .ColumnAutoWidth(true)
    .ColumnHidingEnabled(true)
    .Paging(paging => paging.Enabled(true))
    .Editing(e => e.Mode(GridEditMode.Popup)

        .Popup(p => p
        .ID("popupIfLoginIc")
        //.ShowTitle(true)
        .CloseOnOutsideClick(true)
        .Width(500)
        .Height(500)
        .Position(pos => pos
        .My(HorizontalAlignment.Center, VerticalAlignment.Center)
        .At(HorizontalAlignment.Center, VerticalAlignment.Center)
        .Of("#window")
    ))


        .Form(f => f.Items(items => {

            items.AddSimpleFor(m => m.PART_NUMBER)
            .IsRequired(true);
            items.AddSimpleFor(m => m.TYPE)
            .IsRequired(true);
            items.AddSimpleFor(m => m.PACKAGING)
            .IsRequired(true);
            items.AddSimpleFor(m => m.LOCATION)
            .IsRequired(true);
            items.AddSimpleFor(m => m.QUANTITY)
            .Editor(e => e
                    .NumberBox()
                )
            .IsRequired(true);


        }))
        .Texts(t => t
        .ConfirmDeleteMessage("Are you sure you want to delete ? ")

         )

    //.AllowAdding(true)
    //.AllowDeleting(true)
    //.AllowUpdating(true)
    )

    .OnRowUpdating(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\nfunction(e) {  for (var property in e.oldData) {\r\n      if (!e.newData.hasOwnProperty(property)) {\r\n        e.newData[property] = e.oldData[property];\r\n      }\r\n    }}\r\n");
    PopWriter();
}
))
    .Columns(columns =>
    {

        columns.Add().DataField("PART_NUMBER")
        .Alignment(HorizontalAlignment.Center);
        columns.Add().DataField("PACKAGING")
        .HidingPriority(1)
          .Alignment(HorizontalAlignment.Center); 
        columns.Add().DataField("QUANTITY")
        .HidingPriority(2)
            .Alignment(HorizontalAlignment.Center);
        // .Caption("number");
        //columns.Add().DataField("CAPACITANCE");
        columns.Add().DataField("TYPE")
        .HidingPriority(0)
            .Alignment(HorizontalAlignment.Center);
        columns.Add().DataField("LOCATION")
                .Visible(false);


    })

     //.RtlEnabled(true)
     .StateStoring(s => s
        .Enabled(true)
        .Type(StateStoringType.LocalStorage)
        .StorageKey("storageIC")
    )
    .Paging(p => p.PageSize(10))
    .Pager(p => p
        .ShowPageSizeSelector(true)
        .AllowedPageSizes(new[] { 5, 10, 20 })
        .ShowInfo(true)
    )
    //   .OnSelectionChanged("selectionChanged")
    // .OnContentReady("ContentReady")
    .OnContentReady("DataDoneIC")
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"action-removeIC\"></div>\r\n<div id=\"action-editIC\"></div>\r\n\r\n");
#nullable restore
#line 118 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().SpeedDialAction()
    .ID("action-add-IC")
    .Icon("add")
    .Visible(false)
    .Label("Add row")
    .Index(1)
    .OnClick("addRowIC")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().SpeedDialAction()
    .ID("action-removeIC")
    .Icon("trash")
    .Visible(false)
    .Label("Delete row")
    .Index(2)
    .OnClick("deleteRowIC")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().SpeedDialAction()
    .ID("action-editIC")
    .Icon("edit")
    .Visible(false)
    .Label("Edit row")
    .Index(3)
    .OnClick("editRowIC")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 142 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().SpeedDialAction()
    .ID("action-TakeIC")
    .Icon("edit")
    .Visible(false)
    .Label("Take")
    .Index(3)
    .OnClick("TakeIC")
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 150 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().Popup()
     .ShowTitle(true)
     .Title("Login")
     .ContentTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n<div class=\"form\">\r\n    <div class=\"dx-fieldset\">\r\n        <div class=\"dx-field\">\r\n            <div class=\"dx-field-label\">Usernames</div>\r\n            <div class=\"dx-field-value\">\r\n                ");
#nullable restore
#line 159 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
            Write(Html.DevExtreme().TextBox()
                    .ID("USERNAMEIC")
                   .Placeholder("Enter Username here...")
                  //  .ValueChangeEvent("keyup")

                );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"dx-field\">\r\n            <div class=\"dx-field-label\">Passwords</div>\r\n            <div class=\"dx-field-value\">\r\n                ");
#nullable restore
#line 171 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
            Write(Html.DevExtreme().TextBox()
                    .ID("PASSWORDIC")
                    .Mode(TextBoxMode.Password)
                    .Placeholder("Enter Password here...")
                    .OnValueChanged("showeye")
                     .ValueChangeEvent("keyup")
                     .Buttons(buttons =>
                     {
                buttons.Add()
                .Name("show_passwordIC")
                .Location(TextEditorButtonLocation.After)
                .Widget(w => w.Button()
                    .ID("show_passwordIC")
                    .Visible(false)
                    .Type(ButtonType.Normal)
                    .StylingMode(ButtonStylingMode.Text)
                    .Icon("fas fa-eye")
                    .OnClick("show_passwordIC"));

                buttons.Add()
                .Name("hide_passwordIC")
                .Location(TextEditorButtonLocation.After)
                .Widget(w => w.Button()
                    .ID("hide_passwordIC")
                    .Visible(false)
                    .Icon("fas fa-eye-slash")
                    .OnClick("hide_passwordIC"));
        })


                );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
    PopWriter();
}
)).ID("LoginPopupIC")
.ToolbarItems(toolbarItems =>
{
    toolbarItems.Add()

    .Location(ToolbarItemLocation.After)
    .Toolbar(Toolbar.Bottom)
                .Widget(w => w
                   .Button()
                   .Text("Close")

                   .OnClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("function() {  $(\"#LoginPopupIC\").dxPopup(\"hide\")}");
    PopWriter();
}
))
                );
    toolbarItems.Add()

    .Location(ToolbarItemLocation.Center)
    .Toolbar(Toolbar.Bottom)
                .Widget(w => w
                   .Button()
                   .Text("Login")
                    .ID("loginbtnIC")
                   .OnClick("loginIC")
                );
})
.Height(350)
.Width(364)
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 234 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
Write(Html.DevExtreme().Popup()
    .OnShowing("LoginpopupStateIC")
    .OnHidden("LoginpopupStateHiddenIC")
    .ShowTitle(false)

    .ContentTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n\r\n<div class=\"form\">\r\n    <div class=\"dx-fieldset\">\r\n         <div class=\"dx-field\">\r\n\r\n            <div class=\"dx-field-value\">\r\n                ");
#nullable restore
#line 246 "C:\Users\razis\Desktop\pg\Pages\IC.cshtml"
            Write(Html.DevExtreme().NumberBox()
                    .ID("QuantityIC")
                    .Value(null)
                    .Placeholder("How many you like to take?")
                    .ValueChangeEvent("keyup")
                 //   .OnValueChanged("TakeQuantity")
                    .Width("204")

                );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n         </div>\r\n    </div>\r\n </div>\r\n");
    PopWriter();
}
)).ID("Take-popupIC")
.ToolbarItems(toolbarItems =>
{
    toolbarItems.Add()

    .Location(ToolbarItemLocation.After)
    .Toolbar(Toolbar.Bottom)
                .Widget(w => w
                   .Button()
                   .Text("Close")

                   .OnClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("function() {  $(\"#Take-popupIC\").dxPopup(\"hide\")}");
    PopWriter();
}
))
                );
    toolbarItems.Add()

    .Location(ToolbarItemLocation.Center)
    .Toolbar(Toolbar.Bottom)
                .Widget(w => w
                   .Button()
                   .Text("Take")

                   .OnClick("UpdateQuantityIC")
                );
})

//.OnContentReady("datar")
.Height(196)
.Width(300)

);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<script>


    //#region Show eye icon on password textbox


    function showeye() {
        var pass = $(""#PASSWORDIC"").dxTextBox(""instance"").option(""value"")
        var passwordEditor = $(""#PASSWORDIC"").dxTextBox(""instance"");
        var passCondition = passwordEditor.option(""mode"")
        if (pass != """" && passCondition === ""password"") {
            $(""#show_passwordIC"").dxButton(""instance"").option(""visible"", true);
        }
        else if (pass != """" && passCondition === ""text"") {

            $(""#hide_passwordIC"").dxButton(""instance"").option(""visible"", true);
        }
        else {

            $(""#show_passwordIC"").dxButton(""instance"").option(""visible"", false);
            $(""#hide_passwordIC"").dxButton(""instance"").option(""visible"", false);
        }
    }

    function show_passwordIC() {
        var passwordEditor = $(""#PASSWORDIC"").dxTextBox(""instance"");
        passwordEditor.option(""mode"", passwordEditor.option(""mode"") === ""text"" ? ""password"" : ""text"");
");
            WriteLiteral(@"
        $(""#show_passwordIC"").dxButton(""instance"").option(""visible"", false);
        $(""#hide_passwordIC"").dxButton(""instance"").option(""visible"", true);

    }

    function hide_passwordIC() {
        var passwordEditor = $(""#PASSWORDIC"").dxTextBox(""instance"");

        passwordEditor.option(""mode"", passwordEditor.option(""mode"") === ""text"" ? ""password"" : ""text"");
        $(""#show_passwordIC"").dxButton(""instance"").option(""visible"", true);
        $(""#hide_passwordIC"").dxButton(""instance"").option(""visible"", false);

    }


    //#endregion



    //#region Popuplogin state If take not Login


    function DataDoneIC() {
        var Getloginpopupstate = sessionStorage.getItem(""PpuploginState"");
        if (Getloginpopupstate === ""show"") {
            $(""#Take-popupIC"").dxPopup(""show"")

        } else {
            $(""#Take-popupIC"").dxPopup(""hide"")
        }

    }

    function LoginpopupStateHiddenIC(e) {
        sessionStorage.setItem(""PpuploginState"", ""hide"");


    }");
            WriteLiteral(@"

    function LoginpopupStateIC(e) {

        sessionStorage.setItem(""PpuploginState"", ""show"");

    }


    //#endregion

    function OnGetRowValues(values) {
        DetailImage.SetImageUrl(""FocusedRow.aspx?Photo="" + values[0]);
        DetailImage.SetVisible(true);
        DetailNotes.SetText(values[1]);
    }

    //#region Add Update edit delete floatingActionButton
  
    function onFocusedRowChanged(e) {
      
        focusedRowKey = e.component.option(""focusedRowIndex"");
       // $(""#action-TakeIC"").dxSpeedDialAction(""instance"").option(""visible"", true)
        selectedRowIndex = e.component.getRowIndexByKey(focusedRowKey);
        if (sessionStorage.getItem(""Token"") != null) {
            $(""#action-TakeIC"").dxSpeedDialAction(""instance"").option(""visible"", true)
        }
       
        
       
        
    }
   
    var getGridInstance = function () {
        return $(""#gridIC"").dxDataGrid(""instance"");
    }
    //var getUpdateQuantityInstance = function () {");
            WriteLiteral(@"
    //    return $(""#Quantity"").dxNumberBox(""instance"");
    //}
    var addRowIC = function () {
        getGridInstance().addRow();
        getGridInstance().deselectAll();
    }
    var deleteRowIC = function () {
        getGridInstance().deleteRow(focusedRowKey);
        getGridInstance().deselectAll();
    }
    var editRowIC = function () {
        getGridInstance().editRow(focusedRowKey);
        getGridInstance().deselectAll();
    }
    //var popUp = function (e) {
    //    e.component.collapseAll(-1);
    //    e.component.expandRow(e.currentSelectedRowKeys[0]);
    //}
    var TakeIC = function (e) {
        $(""#Take-popupIC"").dxPopup(""show"")
    }

    $(function () {

        // $(""#date"").val(moment().format('MMM D, YYYY'));

        var today = moment().format('LL');

        var ordersStore = new DevExpress.data.CustomStore({
            key: ""STOCK_ID"",

            load: function () {
                return sendRequest(""/api/IC"");
            },
         ");
            WriteLiteral(@"   insert: function (values) {
                return sendRequest(""/api/IC"", ""POST"", {
                    ""PART_NUMBER"": values.PART_NUMBER,
                    ""TYPE"": values.TYPE,
                    ""PACKAGING"": values.PACKAGING,
                    ""LOCATION"": values.LOCATION,
                    ""IGNORE"": 0,
                    ""QUANTITY"": values.QUANTITY,
                    ""COMPONENTS_ID"": IC,
                    ""CreateDate"": today,
                    ""UpdateDate"": today
                });
            },
            update: function (key, values) {
                return sendRequest(""/api/IC/Update/"" + key, ""PUT"", {
                    ""STOCK_ID"": key,
                    ""PART_NUMBER"": values.PART_NUMBER,
                    ""TYPE"": values.TYPE,
                    ""PACKAGING"": values.PACKAGING,
                    ""LOCATION"": values.LOCATION,
                    ""QUANTITY"": parseInt(values.QUANTITY),
                    ""IGNORE"": 0,

                    ""UpdateDate"": today");
            WriteLiteral(@"
                });
            },
            remove: function (key) {
                return sendRequest(""/api/IC/"" + key, ""DELETE"", {
                    key: key
                });
            }
        });

        var dataGrid = $(""#gridIC"").dxDataGrid({
            dataSource: ordersStore,

        }).dxDataGrid(""instance"");

        $(""#refresh-mode"").dxSelectBox({
            items: [""full"", ""reshape"", ""repaint""],
            value: ""reshape"",
            onValueChanged: function (e) {
                dataGrid.option(""editing.refreshMode"", e.value);
            }
        });

        $(""#clear"").dxButton({
            text: ""Clear"",
            onClick: function () {
                $(""#requests ul"").empty();
            }
        });

        function sendRequest(url, method, data) {
            var d = $.Deferred();

            method = method || ""GET"";

            logRequest(method, url, data);

            $.ajax(url, {
                method: method || """);
            WriteLiteral(@"GET"",
                // data: data,
                data: JSON.stringify(data),
                cache: true,
                headers: {
                    ""DataType"": ""json"",
                    ""Authorization"": ""Bearer "" + sessionStorage.getItem(""Token""),
                    ""Content-Type"": ""application/json""
                },
                statusCode: {
                    401: function () {
                        var role = sessionStorage.getItem(""Role"");
                        if (role == null)
                        {
                            $(""#Take-popupIC"").dxPopup(""hide"");
                            $(""#LoginPopupIC"").dxPopup(""show"")
                        }
                        

                        
                    },
                    200: function () {
                        
                        if (method === ""POST"") {
                            DevExpress.ui.notify({
                                message: ""Success Add New IC"",
       ");
            WriteLiteral(@"                         position: { my: ""top"", at: ""top"", of: $(""#Windows"") },
                                width: 300,
                                shading: false
                            }, ""Success"", 5000);
                        }
                     
                      

                    },
                    204: function ()
                    {
                      var Getloginpopupstate = sessionStorage.getItem(""PpuploginState"");
                        if (Getloginpopupstate === ""show"" && method === ""PUT"") {

                            var PARTNUMBER = dataGrid.cellValue(focusedRowKey, ""PART_NUMBER"");
                            var LOCATION = dataGrid.cellValue(focusedRowKey, ""LOCATION"");
                            sessionStorage.setItem(""PpuploginState"", ""hide"");
                            $(""#Take-popupIC"").dxPopup(""hide"");
                            var myDialog = DevExpress.ui.dialog.custom({
                                title: ""Thanks for Update"",");
            WriteLiteral(@"
                                messageHtml: ""Your item "" + PARTNUMBER + "" Location is : "" + LOCATION,
                                buttons: [{ text: ""Close now"" }]
                            });
                            myDialog.show();

                        }
                        else if (method === ""PUT"") {
                            var PARTNUMBER = dataGrid.cellValue(focusedRowKey, ""PART_NUMBER"");
                            DevExpress.ui.notify({
                                message: ""Success Update "" + PARTNUMBER,
                                position: { my: ""top"", at: ""top"", of: $(""#Windows"") },
                                width: 300,
                                shading: false
                            }, ""Success"", 5000);
                        }
                        else if (method === ""DELETE"") {
                            var PARTNUMBER = dataGrid.cellValue(focusedRowKey, ""PART_NUMBER"");
                            DevExpress.ui.notify({
      ");
            WriteLiteral(@"                          message: ""Success Delete "" +  PARTNUMBER,
                                position: { my: ""top"", at: ""top"", of: $(""#Windows"") },
                                width: 300,
                                shading: false
                            }, ""Success"", 5000);
                        }

                    }
                }

            }).done(function (result) {
                d.resolve(method === ""GET"" ? result.data : result);
            }).fail(function (xhr) {
                var response = xhr.responseJSON;


                if (xhr.status == 400) {
                    $.each(response.errors, function (fieldName, errorBag) {
                        //output the fieldname for this error
                        console.log(fieldName);

                        // output each error message for this field
                        $.each(errorBag, function (i, message) {
                            DevExpress.ui.notify(message);
                    ");
            WriteLiteral(@"        //d.reject(message);
                            //$(""#my-popup"").dxPopup(""show"")
                        });
                    });
                }

            });


            return d.promise();
        }

        function logRequest(method, url, data) {
            var args = Object.keys(data || {}).map(function (key) {
                return key + ""="" + data[key];
            }).join("" "");

            var logList = $(""#requests ul""),
                time = DevExpress.localization.formatDate(new Date(), ""HH:mm:ss""),
                newItem = $(""<li>"").text([time, method, url.slice(URL.length), args].join("" ""));

            logList.prepend(newItem);
        }
        var role = sessionStorage.getItem(""Role"");
        
        
          
        
            if (role == ""Admin"") {
                $(""#action-add-IC"").dxSpeedDialAction(""instance"").option(""visible"", true);
                $(""#action-removeIC"").dxSpeedDialAction(""instance"").option(""visible"", true);");
            WriteLiteral(@"
                $(""#action-editIC"").dxSpeedDialAction(""instance"").option(""visible"", true);

            }
        

        /*floatingActionButton location setting*/

        DevExpress.config({
            floatingActionButtonConfig: {
                icon: ""rowfield"",
                position: {
                    my: ""right bottom"",
                    at: ""right bottom"",
                    of: ""#app-container"",
                    offset: ""-16 -16""
                }
            }
        });
    });




    //#endregion



    //#region UpdateQuantity

  
    var UpdateQuantityIC = function () {
        var dataGrid = $(""#gridIC"").dxDataGrid(""instance"");
        var OriQuantitys = dataGrid.cellValue(focusedRowKey, ""QUANTITY"");
        var Quantitys = $(""#QuantityIC"").dxNumberBox(""instance"").option(""value"")
       
        var result = DevExpress.ui.dialog.confirm(""Are you sure only "" + Quantitys + "" you take?"", ""Confirm Take"");

        result.done(function (dialogR");
            WriteLiteral(@"esult) {
         
            if (dialogResult == true) {

                if (OriQuantitys < Quantitys) {
                    DevExpress.ui.notify(""Quantity invalid"");
                }
                else {
                    var TakeQuentitys = OriQuantitys - Quantitys;
                    dataGrid.cellValue(focusedRowKey, ""QUANTITY"", TakeQuentitys);
                    dataGrid.saveEditData();

                }



               
            }
        });

        //  DevExpress.ui.notify(""Quantity"" + Quantitys);




    }



    //#endregion



    //#region Login


    function loginIC() {

        var user = $(""#USERNAMEIC"").dxTextBox(""instance"").option(""value"")
        var pass = $(""#PASSWORDIC"").dxTextBox(""instance"").option(""value"")

        var settings = {

            ""url"": ""/users/authenticate"",
            ""method"": ""POST"",
            ""timeout"": 0,
            ""headers"": {

                ""Content-Type"": ""application/json""
            },
 ");
            WriteLiteral(@"           statusCode: {

                200: function () {
                    //$(""#LoginPopupIC"").dxPopup(""hide"");
                    //$(""#Take-popupIC"").dxPopup(""show"");
                    sessionStorage.setItem(""PpuploginState"", ""show"");
                    //$(""#Take-popupIC"").dxPopup(""hide"");
                    //$(""#LoginPopupIC"").dxPopup(""show"")
                    window.location.href = window.location;
                }
            },
            ""data"": JSON.stringify({ ""username"": user, ""password"": pass }),

        };


        $.ajax(settings).done(function (data) {


            sessionStorage.setItem(""Token"", data.Token);
            sessionStorage.setItem(""Role"", data.Role);
            sessionStorage.setItem(""Username"", data.Username);

            DevExpress.ui.notify({
                message: ""Success Login, Hello! "" + sessionStorage.getItem(""Username""),
                position: { my: ""top"", at: ""top"", of: $('#Windows') },
                width: 300,
    ");
            WriteLiteral(@"            shading: false
            }, ""Success"", 5000);


        })
            .fail(function (data) {
                //var pass = $(""#Passwordss"")
                //    .dxTextBox(""instance"")
                //    .option(""value"")
                //  DevExpress.ui.notify(""Warning message"", ""warning"", 500);
                // DevExpress.ui.notify(""value:"" + pass + user);
                DevExpress.ui.notify({
                    message: ""Username or Password is invalid"",
                    position: { my: ""top"", at: ""top"", of: $('#Windows') },
                    width: 300,
                    shading: false
                }, ""error"", 5000);

                //window.location.href = window.location;



            });








    }



      //#endregion



</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_IC> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_IC> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_IC>)PageContext?.ViewData;
        public Pages_IC Model => ViewData.Model;
    }
}
#pragma warning restore 1591
