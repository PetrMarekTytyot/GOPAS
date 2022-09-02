using ToDoList.Models;
using ToDoList.Views;

namespace ToDoList.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private ModelFacade model;

        public MainPresenter(ModelFacade model)
        {
            this.model = model;
        }

        public IView<MainViewData> MainView { get; set; }
        public IView<DetailViewData> DetailView { get; set; }

        public void AddAction()
        {
            if (this.DetailView == null || ((Form)DetailView).IsDisposed)
                DetailView = new DetailForm(this);
            ((Form)DetailView).Show();
            DetailView.UpdateView(new DetailViewData()
            {
                ToDo = new ToDo()
            });
        }

        public void DeleteAction(Guid id)
        {
            model.DeleteToDo(id);
            MainView.UpdateView(new MainViewData()
            {
                Todos = model.List
            });
        }

        public void EditAction(ToDo toDo)
        {
            if (this.DetailView == null || ((Form)DetailView).IsDisposed)
                DetailView = new DetailForm(this);
            ((Form)DetailView).Show();
            DetailView.UpdateView(new DetailViewData()
            {
                ToDo = toDo
            });
        }

        public void SaveAction(ToDo toDo)
        {
            model.SaveToDo(toDo);
            ((Form)DetailView).Hide();
            MainView.UpdateView(new MainViewData()
            {
                Todos = model.List.ToList(),
                BgColor = model.List.Count() % 2 == 0 ? Color.Blue : Color.Green
            });
        }
    }
}
