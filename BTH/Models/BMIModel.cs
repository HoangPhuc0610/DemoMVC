using Microsoft.JSInterop.Infrastructure;

namespace BMIApp.Models
{
    public class BMIModel
    {
        public float Weight { get; set; }
        public float Height { get; set; }

        public float CalculateBMI()
        {
            if (Height > 0)
            {
                return Weight / (Height * Height);
            }
            return 0;
        }
    }
}
