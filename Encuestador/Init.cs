using System.Windows.Forms;
namespace Encuestador
{
    public class Init:ApplicationContext
    {
        public Init()
        {
            var frm = new frmLogin();
            frm.Show();
        }

    }
}
