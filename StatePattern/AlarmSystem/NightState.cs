namespace AlarmSystem
{
    public class NightState : State
    {
        private static NightState singleton = new NightState();
        private NightState()
        {

        }

        public static State GetInstance()
        {
            return singleton;
        }

        public void DoAlarm(Context context)
        {
            context.RecordLog("Use alarm (night)");
        }

        public void DoClock(Context context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoPhone(Context context)
        {
            context.RecordLog("Communication (night)");
        }

        public void DoUse(Context context)
        {
            context.RecordLog("Emergency!! Use cashbox (night)");
        }

        public override string ToString()
        {
            return "[Night]";
        }
    }
}