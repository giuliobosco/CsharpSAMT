using _05_SecondoGrado.Model;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace _05_SecondoGrado.ViewModel {
    public class EquationViewModel : BindableBase {
        #region =================== costants ===================

        public const double XMIN = -4;
        public const double XMAX = 4;
        public const double YMIN = -20;
        public const double YMAX = 20;
        public const double STEP = 0.5;

        #endregion

        #region =================== static Members =============

        #endregion

        #region =================== properties & members =======

        private Equation model;
        private DispatcherTimer timer;
        private double x;

        public double A {
            get { return model.A; }
            set {
                if (value == model.A) {
                    return;
                }

                model.A = value;
                OnPropertyChanged(() => A);
                UpDateProperties();
            }
        }

        public double B {
            get { return model.B; }
            set {
                if (value == model.B) {
                    return;
                }

                model.B = value;
                OnPropertyChanged(() => B);
                UpDateProperties();
            }
        }

        public double C {
            get { return model.C; }
            set {
                if (value == model.C) {
                    return;
                }

                model.C = value;
                OnPropertyChanged(() => C);
                UpDateProperties();
            }
        }

        public double Root1 {
            get { return model.Root1; }
        }

        public double Root2 {
            get { return model.Root2; }
        }

        public Point2D Vertex {
            get { return model.Vertex(); }
        }

        public ObservableCollection<Point2D> Points { get; private set; }

        public IDelegateCommand DrawCommand { get; private set; }

        #endregion

        #region =================== constructors ===============

        public EquationViewModel() {
            this.model = new Equation();

            this.A = 5;
            this.B = 3;

            Points = new ObservableCollection<Point2D>();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Timer_Tick;

            DrawCommand = new DelegateCommand(OnDraw);
        }

        private void Timer_Tick(object sender, EventArgs e) {
            if (x > XMAX) {
                timer.Stop();
            }

            double y = model.Y(x);

            Point2D coordinata = new Point2D(x, y);
            Point2D normalized = Normalize(coordinata);

            Points.Add(normalized);
            x += STEP;
        }

        #endregion

        #region =================== help methods ===============

        private void OnDraw(object obj) {
            Points.Clear();
            x = XMIN;
            timer.Start();
        }

        private void UpDateProperties() {
            OnPropertyChanged(() => Root1);
            OnPropertyChanged(() => Root2);
            OnPropertyChanged(() => Vertex);
        }

        /// <summary>
        /// Transform a point of the function for the graphic rappresentation.
        /// </summary>
        /// <param name="point">Point calculated in the function.</param>
        /// <returns>Point to rappresent in the canvas.</returns>
        private Point2D Normalize(Point2D point) {
            double canvasWidth = 200;
            double canvasHeight = 200;
            Point2D result = new Point2D() {
                X = canvasWidth * (point.X - XMIN) / (XMAX - XMIN),
                Y = canvasHeight - canvasHeight * (point.Y - YMIN) / (YMAX - YMIN)
            };

            return result;
        }

        #endregion

        #region =================== general methods ============

        #endregion
    }
}