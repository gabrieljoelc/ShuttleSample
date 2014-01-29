using Shuttle.Core.Infrastructure;
using Shuttle.ESB.Core;
using ShuttleSample.Messages;

namespace ShuttleSample.Service.Editor
{
    public class SubmitArticleToEditorHandler : IMessageHandler<SubmitArticleToEditor>
    {
        private readonly ILog _log;

        public SubmitArticleToEditorHandler()
        {
            _log = Log.For(this);
        }

        public void ProcessMessage(HandlerContext<SubmitArticleToEditor> context)
        {
            _log.Information(context.Message.Article);
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}