<script type="text/javascript">
    function OnCommandExecuted(s, e) {
        $.ajax({
            url: "@Url.Action("ItemContentPartial")",
            type: "POST",
            dataType: "html",
            success: function (data) {
                $('#templatecontent').html(data);
            }
        });
    }
</script>
@Html.DevExpress().Ribbon(Sub(settings)
                                   settings.Name = "ribbon"
                                   settings.ClientSideEvents.CommandExecuted = "OnCommandExecuted"

                                   Dim Group = settings.Tabs.Add("Ribbon Tab").Groups.Add("RibbonGroup")

                              Dim item1 = Group.Items.Add(MVCxRibbonItemType.ButtonItem, "item1")
                              Dim ribitem1 As RibbonButtonItem = item1
                              ribitem1.SmallImage.IconID = IconID.TasksNewtask16x16
                              item1.Text = "New"

                              Dim item2 = Group.Items.Add(MVCxRibbonItemType.ButtonItem, "item2")
                              Dim ribitem2 As RibbonButtonItem = item2
                              ribitem2.SmallImage.IconID = IconID.TasksEdittask16x16
                              item2.Text = "Edit"

                              Dim itemCustom As MVCxRibbonTemplateItem = Group.Items.Add(MVCxRibbonItemType.TemplateItem, "tmpl")
                              itemCustom.ItemStyle.Width = 150
                              itemCustom.Size = DevExpress.Web.ASPxRibbon.RibbonItemSize.Large
                              itemCustom.SetContent("<div id='templatecontent'></div>")
                          End Sub
).GetHtml()