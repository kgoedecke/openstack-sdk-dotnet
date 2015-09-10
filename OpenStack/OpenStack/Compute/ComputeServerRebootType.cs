// /* ============================================================================
// Copyright 2014 Hewlett Packard
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ============================================================================ */

using OpenStack.Common;

namespace OpenStack.Compute
{
    /// <summary>
    /// Represents a Compute Server reboot type.
    /// </summary>
    public enum ComputeServerRebootType
    {
        /// <summary>
        /// The compute server is being hard rebooted.
        /// </summary>
        Hard_Reboot,

        /// <summary>
        /// The compute server is being soft rebooted.
        /// </summary>
        Reboot
    }

    /// <summary>
    /// Static class for holding ComputeServer related extension methods.
    /// </summary>
    public static class ComputeServerRebootTypeExtentions
    {
        /// <summary>
        /// Creates a ComputeServerRebootType enum from a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>A ComputeServerRebootType enum.</returns>
        public static ComputeServerRebootType GetComputeServerRebootType(this string input)
        {
            input.AssertIsNotNullOrEmpty("input", "Cannot get computer server reboot type with null or empty value.");

            switch (input.ToLowerInvariant())
            {
                case "hard_reboot":
                    return ComputeServerRebootType.Hard_Reboot;
                case "reboot":
                    return ComputeServerRebootType.Reboot;
                default:
                    // Is there an appropriate expection i can throw?s
                    return ComputeServerRebootType.Hard_Reboot;
            }
        }
    }
}
