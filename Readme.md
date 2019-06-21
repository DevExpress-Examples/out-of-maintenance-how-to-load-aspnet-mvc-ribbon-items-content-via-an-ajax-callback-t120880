<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T120880/Controllers/HomeController.cs)
* **[Index.cshtml](./CS/T120880/Views/Home/Index.cshtml)**
* [ItemContentPartial.cshtml](./CS/T120880/Views/Home/ItemContentPartial.cshtml)
<!-- default file list end -->
# How to load ASP.NET MVC Ribbon item's content via an AJAX callback
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t120880)**
<!-- run online end -->


This example demonstrate how to load ASP.NET MVC Ribbon item's content via an AJAX callback.<br />A div container with the defined ID attribute is placed in the MVCxRibbonTemplateItem. Then, the content of this container is updated via an AJAX request initialized on a ribbon button click.<br />The pecularity of this scenario is that the new content will not be able to increase of decrease width of a template item because ribbon items have defined widths. These widths should be defined manually or will be calculated automatically on control initialization. So the MVCxRibbonTemplateItem's width should be fixed.

<br/>


