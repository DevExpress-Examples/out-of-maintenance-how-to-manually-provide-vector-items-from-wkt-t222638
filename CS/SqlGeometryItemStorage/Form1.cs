using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace SqlGeometryItemStorageExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #SqlGeometryItemStorage
        private void Form1_Load(object sender, EventArgs e) {
            SqlGeometryItemStorage storage = new SqlGeometryItemStorage();

            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(-0.1275 51.507222 0 10)", 0));
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(12.5 41.9 0 10)", 1));
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(2.3508 48.8567 0 10)", 2));
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(13.38 52.52 0 10)", 3));
            storage.Items.Add(SqlGeometryItem.FromWkt("POINT(-3.68 40.4 0 10)", 4));

            VectorItemsLayer layer = new VectorItemsLayer() { Data = storage };
            layer.DataLoaded += layer_DataLoaded;
            mapControl1.Layers.Add(layer);
        }
        #endregion #SqlGeometryItemStorage

        void layer_DataLoaded(object sender, DataLoadedEventArgs e) {
            mapControl1.ZoomToFitLayerItems(0.4);
        }
    }
}
