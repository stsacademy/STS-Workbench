using STS.Workbench.TablesDiagram.DiagramPreviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public class LoadingHelper
    {
        private Thread worker;
        private Thread timer;

        private LoadingForm loadingForm = null;

        public Action Action { get; private set; }

        public LoadingHelper(Action action)
        {
            //TODO
            throw new NotImplementedException();

            Action = action;

            timer = new Thread(tick);
            timer.Start();

        }

        private void tick()
        {
            if (loadingForm == null)
            {
                loadingForm = new LoadingForm();
                loadingForm.ChangeProgressBarStyle(ProgressBarStyle.Marquee);
                loadingForm.Show();

                worker = new Thread(() =>
                {
                    Action();
                    worker.Abort();
                });

                worker.Start();
            }
            Thread.Sleep(1000);

            if (!worker.IsAlive)
                timer.Abort();

            if (loadingForm.StopClicked)
            {
                worker.Join(500);
                worker.Abort();
                loadingForm.Dispose();
            }
        }
    }
}