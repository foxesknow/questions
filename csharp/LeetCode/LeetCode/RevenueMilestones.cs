using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RevenueMilestones
    {
        public int[] GetMilestoneDays(int[] revenues, int[] milestones)
        {
            Array.Sort(milestones);

            for(int i = 1; i < revenues.Length; i++)
            {
                revenues[i] += revenues[i - 1];
            }

            var days = new int[milestones.Length];

            for(int i = 0; i < milestones.Length; i++)
            {
                var milestone = milestones[i];
                var index = Array.BinarySearch(revenues, milestone);

                if(index == revenues.Length)
                {
                    days[i] = -1;
                }
                else if(index < 0)
                {
                    var normalizedIndex = ~index;
                    days[i] = normalizedIndex + 1;
                }
                else
                {
                    days[i] = index + 1;
                }
            }

            return days;
        }

        public int[] GetMilestoneDays2(int[] revenues, int[] milestones)
        {
            Array.Sort(milestones);

            for(int i = 1; i < revenues.Length; i++)
            {
                revenues[i] += revenues[i - 1];
            }

            var days = new int[milestones.Length];

            var milestoneIndex = 0;
            for(int i = 0; i < revenues.Length && milestoneIndex < milestones.Length; i++)
            {
                if(revenues[i] < milestones[milestoneIndex]) continue;

                while(milestoneIndex < milestones.Length && revenues[i] >= milestones[milestoneIndex])
                {
                    days[milestoneIndex] = i + 1;
                    milestoneIndex++;
                }
            }

            for(int i = milestoneIndex; i < milestones.Length; i++)
            {
                days[i] = -1;
            }

            return days;
        }
    }
}
