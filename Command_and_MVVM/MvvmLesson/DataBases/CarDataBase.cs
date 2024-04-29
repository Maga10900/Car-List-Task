using MvvmLesson.Models;
using System.Collections.ObjectModel;

namespace MvvmLesson.DataBases;

public static class CarDataBase
{
    public static ObservableCollection<Car>? CarsDB { get; set; } = new ObservableCollection<Car>();

}
