using System;
namespace LogicProject
{
	public static class Mathematics
	{
        public static int SumElements(int[] mas)
        {
            if (mas.Length == 0)
                throw new Exception("Пустой массив!");
            int result = 0;
            try
            {
                foreach (int element in mas)
                {
                    result = checked(result + element);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Произошло исключение: {e.Message}");
            }
            return result;
        }
    }
}

