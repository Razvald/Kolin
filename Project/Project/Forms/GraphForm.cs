using Project.Database;
using ScottPlot;

namespace Project.Forms
{
    public partial class GraphForm : Form
    {
        private readonly ProfilePoint[] _points;
        private readonly Picket[] _pickets;
        private readonly PicketValue[] _picketValues;

        public GraphForm(ProfilePoint[] points, Picket[] pickets, PicketValue[] picketValues)
        {
            InitializeComponent();
            _points = points;
            _pickets = pickets;
            _picketValues = picketValues;

            PopulateProfilePointsComboBox();
        }

        private void PopulateProfilePointsComboBox()
        {
            cmb.Items.Clear();
            foreach (var point in _points)
            {
                cmb.Items.Add(point.PointID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        public void Draw()
        {
            plt.Plot.Clear();
            foreach (var point in _points)
            {
                plt.Plot.Add.Circle(
                    xCenter: point.XCoordinate,
                    yCenter: point.YCoordinate,
                    radius: 3);
            }

            foreach (var point in _pickets)
            {
                plt.Plot.Add.Circle(
                    xCenter: point.XCoordinate,
                    yCenter: point.YCoordinate,
                    radius: 1);
            }

            plt.Plot.Axes.SetLimits(-15, 45, -5, 40);
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            plt.Reset(); // Очистить график при изменении выбора ProfilePoint

            if (cmb.SelectedItem != null)
            {
                var picketsForPoint = _pickets.Where(p => p.ProfilePointID == (int)cmb.SelectedItem);
                //var asd = _picketValues.Where(pv => pv.PicketID == picketsForPoint.Any(p => p.PicketID));
                var picketValuesForPoint = _picketValues.Where(pv => picketsForPoint.Any(p => p.PicketID == pv.PicketID));

                List<PieSlice> slices = new();

                foreach (var picketValue in picketValuesForPoint)
                {
                    PieSlice slice = new()
                    {
                        Value = picketValue.Amplitude,
                        FillColor = GetColorForWellType(picketValue.PicketID),
                        Label = $"Picket {picketValue.PicketID}"
                    };

                    slices.Add(slice);
                }
                var pie = plt.Plot.Add.Pie(slices);

                pie.ExplodeFraction = .1;
                pie.ShowSliceLabels = true;
                pie.SliceLabelDistance = 1.8;

                plt.Plot.Axes.SquareUnits();
                plt.Refresh();
            }
        }

        private static ScottPlot.Color GetColorForWellType(int id)
        {
            return id switch
            {
                1 => Colors.Red,
                2 => Colors.Blue,
                3 => Colors.Green,
                4 => Colors.Yellow,
                5 => Colors.Pink,
                _ => Colors.Black,
            };
        }
    }
}
