namespace AlarmSystem
{
    public class DayState : State
    {
        private static DayState singleton = new DayState();
        private DayState()
        {

        }

        public static State GetInstance()
        {
            return singleton;
        }

        public void DoAlarm(Context context)
        {
            context.RecordLog("Use alarm (day)");
        }

        public void DoClock(Context context, int hour)
        {
            if(hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("Communication (day)");
        }

        public void DoUse(Context context)
        {
            context.RecordLog("Use cashbox (day)");
        }

        public override string ToString()
        {
            return "[Day]";
        }
    }
}
