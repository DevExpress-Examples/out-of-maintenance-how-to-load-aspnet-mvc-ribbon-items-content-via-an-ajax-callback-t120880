@Html.DevExpress().Button(Sub(settings)
                                   settings.Name = "TemplButton"
                                   settings.Text = "Custom Button"
                                   settings.UseSubmitBehavior = True
                           End Sub
).GetHtml()

