<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576681/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T222638)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/SqlGeometryItemStorage/Form1.cs) (VB: [Form1.vb](./VB/SqlGeometryItemStorage/Form1.vb))**
<!-- default file list end -->
# How to manually provide vector items from WKT


This example demonstrates how to manually provide vector items from the SQL Geometry Well-Known Text.


<h3>Description</h3>

To manually provide vector items from WKT, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSqlGeometryItemStoragetopic">SqlGeometryItemStorage</a>&nbsp;object and assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic">VectorItemsLayer.Data</a>&nbsp;property. Then add <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraMapSqlGeometryItemtopic.aspx">SqlGeometryItem</a>&nbsp;objects, created using the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSqlGeometryItem_FromWkttopic">SqlGeometryItem.FromWkt</a>&nbsp;method, to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSqlGeometryItemStorage_Itemstopic">SqlGeometryItemStorage.Items</a>&nbsp;collection.

<br/>


