using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2 {
    public class MainViewViewModel : ModelBase {
        int size = 0;
        SizeModel[] models = new SizeModel[] {
        new SizeModel() { ImagePath =  "/Assets/small.jpg", Name = "Espresso" },
        new SizeModel() { ImagePath = "/Assets/medium.jpg", Name = "Kleiner Schwarzer"},
        new SizeModel() { ImagePath = "/Assets/big.jpg", Name = "Verlängerter" }
    };

        public SizeModel Active {
            get {
                if (size >= 0 && size <= models.Length)
                    return models[size];
                return models[0];
            }
        }


        public int Size {
            get {
                return size;
            }
            set {
                if (size != value) {
                    size = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged("Active");
                }
            }
        }
    }
}
