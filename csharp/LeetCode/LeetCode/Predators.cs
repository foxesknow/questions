using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Predators
    {
        public static int minimumGroups(List<int> predators)
        {
            var groups = 0;

            while(true)
            {
                // Find the ones at the "top of the tree"
                var matches = new HashSet<int>();

                for(int i = 0; i < predators.Count; i++)
                {
                    if(predators[i] == -1) matches.Add(i);
                }

                // We're done if there's nobody left
                if(matches.Count== 0) break;

                groups++;

                // Now remove the top of tree from consideration
                // and make the ones under them the apex
                for(int i = 0; i < predators.Count; i++)
                {
                    if(predators[i] == -1) 
                    {
                        predators[i] = -2;
                    }
                    else if(matches.Contains(predators[i]))
                    {
                        predators[i] = -1;
                    }
                }
            }
        
            return groups;
        }
    }
}
