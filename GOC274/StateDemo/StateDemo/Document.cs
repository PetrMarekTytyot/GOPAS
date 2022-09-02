namespace StateDemo
{
    public class Document
    {
        private interface IDocumentState
        {
            void SetTitle(Document document, string value);
            bool IsValid(Document document);
            void Approve(Document document);
            void Cancel(Document document);
            void Archive(Document document);
        }
        private class Draft : IDocumentState
        {
            public void Approve(Document document) =>
                document.state = new Approved();

            public void Archive(Document document) =>
                throw new NotImplementedException();


            public void Cancel(Document document) =>
                document.state = new Canceled();

            public bool IsValid(Document document) => true;

            public void SetTitle(Document document, string value)
            {
                document.title = value;
            }
        }
        private class Approved : IDocumentState
        {
            public void Approve(Document document) =>
                throw new NotImplementedException();

            public void Archive(Document document) =>
                document.state = new Archived();

            public void Cancel(Document document) =>
                throw new NotImplementedException();
            
            public bool IsValid(Document document) =>
                !String.IsNullOrEmpty(document.title);

            public void SetTitle(Document document, string value)
            {
                document.title = value;
            }
        }
        private class Canceled : IDocumentState
        {
            public void Approve(Document document)
            {
                throw new NotImplementedException();
            }

            public void Archive(Document document)
            {
                throw new NotImplementedException();
            }

            public void Cancel(Document document)
            {
                throw new NotImplementedException();
            }

            public bool IsValid(Document document) => true;

            public void SetTitle(Document document, string value)
            {
                throw new Exception("Can't change title in canceled state");
            }
        }
        private class Archived : IDocumentState
        {
            public void Approve(Document document)
            {
                throw new NotImplementedException();
            }

            public void Archive(Document document)
            {
                throw new NotImplementedException();
            }

            public void Cancel(Document document)
            {
                throw new NotImplementedException();
            }

            public bool IsValid(Document document) =>
                !String.IsNullOrEmpty(document.title);

            public void SetTitle(Document document, string value)
            {
                throw new Exception("Can't change title in archived state");
            }
        }

        private IDocumentState state = new Draft();

        private string title;

        public string Title
        {
            get { return title; }
            set {
                state.SetTitle(this, value);
            }
        }

        public bool IsValid => state.IsValid(this);

        public void Approve() => state.Approve(this);
        public void Cancel() => state.Cancel(this);
        public void Archive() => state.Archive(this);

    }
}
