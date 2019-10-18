using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace DevReach2019.Forms.Models
{
    public class AgendaItem : Appointment
    {
        private Color titleColor;
        private Color detailColor;
        private Color sessionTechColor;
        private string sessionType;
        private Session session;

        public AgendaItem()
        {
            // defaults
            titleColor = (Color)Application.Current.Resources["DevReachLightTextColor"];
            detailColor = (Color)Application.Current.Resources["DevReachAgendaLightGray"];
        }

        public Color TitleColor
        {
            get => titleColor;
            set => UpdateValue(ref titleColor, value);
        }

        public Color DetailColor
        {
            get => detailColor;
            set => UpdateValue(ref detailColor, value);
        }

        public Color SessionTechColor
        {
            get => sessionTechColor;
            set => UpdateValue(ref sessionTechColor, value);
        }

        public string SessionType
        {
            get => sessionType;
            set => UpdateValue(ref sessionType, value);
        }

        public Session Session
        {
            get => session;
            set => UpdateValue(ref session, value);
        }
    }
}
