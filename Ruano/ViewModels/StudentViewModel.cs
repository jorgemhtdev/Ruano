namespace Ruano.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Ruano.Models;
    using Xamarin.Forms;

    public class StudentViewModels
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentViewModels()
        {
            try
            {
                Students = new ObservableCollection<Student>();

                var student = new Student()
                {
                    Age = 10,
                    Course = "Inglés",
                    Name = "Luis"
                };

                Students.Add(student);

                student = new Student()
                {
                    Age = 11,
                    Course = "Ciencia",
                    Name = "Vanesa"
                };

                Students.Add(student);
            }
            catch (System.Exception ex)
            {
                var exception = ex;
            }


        }

        public ICommand StudentItemCommand => 
            new Command<Student>(StudentItem);

        public void StudentItem(Student student)
        {
            var test = student;
        }


    }
}
