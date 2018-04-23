# How to manually provide vector items from WKT


This example demonstrates how to manually provide vector items from the SQL Geometry Well-Known Text.


<h3>Description</h3>

To manually provide vector items from WKT, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSqlGeometryItemStoragetopic">SqlGeometryItemStorage</a>&nbsp;object and assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic">VectorItemsLayer.Data</a>&nbsp;property. Then add <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraMapSqlGeometryItemtopic.aspx">SqlGeometryItem</a>&nbsp;objects, created using the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSqlGeometryItem_FromWkttopic">SqlGeometryItem.FromWkt</a>&nbsp;method, to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSqlGeometryItemStorage_Itemstopic">SqlGeometryItemStorage.Items</a>&nbsp;collection.

<br/>


