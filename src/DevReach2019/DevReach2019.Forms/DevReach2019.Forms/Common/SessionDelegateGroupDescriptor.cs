namespace DevReach2019.Forms.Common
{
    public class SessionDelegateGroupDescriptor : Telerik.XamarinForms.DataControls.ListView.DelegateGroupDescriptor
    {
        public SessionDelegateGroupDescriptor()
        {
            this.KeyExtractor = DayKeyExtractor;
        }

        private object DayKeyExtractor(object arg)
        {
            return (arg as Models.Session)?.StartTime.DayOfWeek;
        }
    }
}
