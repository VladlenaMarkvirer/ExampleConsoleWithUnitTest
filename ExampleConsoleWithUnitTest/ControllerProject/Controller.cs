using LogicProject;

namespace ControllerProject
{

    public static class Controller
    {
        public static string TryIncreaseRubles(ref Money money)
        {
            string result = "";
            try
            {
                money = !money;
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public static string TrySumMas(int[] mas, out int result)
        {
            string error = "";
            result = 0;
            try
            {
                result = Mathematics.SumElements(mas);
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }
    }

}