using _05_SecondoGrado.Model;
using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SecondoGrado.ViewModel {
    public class EquationViewModel : BindableBase {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        private Equation model;

        public double A {
            get { return model.A; }
            set { model.A = value; }
        }

        public double B {
            get { return model.B; }
            set { model.B = value; }
        }

        public double C {
            get { return model.C; }
            set { model.C = value; }
        }

        public double Root1 {
            get { return model.Root1; }
        }

        public double Root2 {
            get { return model.Root2; }
        }

        public Point2D Vertex {
            get { return model.Vertex();  }
        }

        public IDelegateCommand DrawCommand { get; private set; }

        #endregion

        #region =================== constructors ===============
        public EquationViewModel() {
            this.model = new Equation();

            this.A = 5;
            this.B = 3;

            DrawCommand = new DelegateCommand(OnDraw);
        }
        #endregion

        #region =================== help methods ===============
        private void OnDraw(object obj) {
            throw new NotImplementedException();
        }
        #endregion

        #region =================== general methods ============
        #endregion
    }
}
