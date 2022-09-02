using Ninject;
using System.Drawing;
using ToDoList.Models;

namespace ToDoList.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IKernel container;
        
        private IModelFacade model;
        private IViewHandler viewHandler;


        public MainPresenter(IKernel container)
        {
            this.container = container;
            this.model = container.Get<IModelFacade>();
            this.viewHandler = container.Get<IViewHandler>();
        }

        public IView<MainViewData> MainView { get; set; }
        public IView<DetailViewData> DetailView { get; set; }

        public void AddAction()
        {
            if (!viewHandler.IsUsable(DetailView))
                DetailView = container.Get<IView<DetailViewData>>();
            viewHandler.Display(DetailView);
            DetailView.UpdateView(new DetailViewData()
            {
                ToDo = new ToDo()
            });
        }

        public ToDo DeleteAction(Guid id)
        {
            var result = model.DeleteToDo(id);
            MainView.UpdateView(new MainViewData()
            {
                Todos = model.List
            });
            return result;
        }

        public void EditAction(ToDo toDo)
        {
            if (!viewHandler.IsUsable(DetailView))
                DetailView = container.Get<IView<DetailViewData>>();
            viewHandler.Display(DetailView);
            DetailView.UpdateView(new DetailViewData()
            {
                ToDo = toDo
            });
        }

        public SaveResult SaveAction(ToDo toDo)
        {
            var result = model.SaveToDo(toDo);
            viewHandler.Hide(DetailView);
            MainView.UpdateView(new MainViewData()
            {
                Todos = model.List.ToList(),
                BgColor = model.List.Count() % 2 == 0 ? Color.Blue : Color.Green
            });
            return result;
        }
    }
}
