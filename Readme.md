<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552639/14.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T120880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T120880/Controllers/HomeController.cs)
* **[Index.cshtml](./CS/T120880/Views/Home/Index.cshtml)**
* [ItemContentPartial.cshtml](./CS/T120880/Views/Home/ItemContentPartial.cshtml)
<!-- default file list end -->
# How to load ASP.NET MVC Ribbon item's content via an AJAX callback
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t120880/)**
<!-- run online end -->


This example demonstrate how to load ASP.NET MVC Ribbon item's content via an AJAX callback.<br />A div container with the defined ID attribute is placed in the MVCxRibbonTemplateItem. Then, the content of this container is updated via an AJAX request initialized on a ribbon button click.<br />The pecularity of this scenario is that the new content will not be able to increase of decrease width of a template item because ribbon items have defined widths. These widths should be defined manually or will be calculated automatically on control initialization. So the MVCxRibbonTemplateItem's width should be fixed.

<br/>


