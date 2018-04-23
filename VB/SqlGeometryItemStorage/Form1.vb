Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace SqlGeometryItemStorageExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#SqlGeometryItemStorage"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim storage As New SqlGeometryItemStorage()

            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(-0.1275 51.507222 0 10)", 0))
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(12.5 41.9 0 10)", 1))
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(2.3508 48.8567 0 10)", 2))
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(13.38 52.52 0 10)", 3))
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(-3.68 40.4 0 10)", 4))

            Dim layer As New VectorItemsLayer() With {.Data = storage}
            AddHandler layer.DataLoaded, AddressOf layer_DataLoaded
            mapControl1.Layers.Add(layer)
        End Sub
        #End Region ' #SqlGeometryItemStorage

        Private Sub layer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            mapControl1.ZoomToFitLayerItems(0.4)
        End Sub
    End Class
End Namespace
