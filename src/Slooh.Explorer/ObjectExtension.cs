using System;

namespace Slooh.Explorer
{
    /// <summary>
    /// Extensions to the <see cref="object"/> class.
    /// </summary>
    static class ObjectExtension
    {
        /// <summary>
        /// Executes an <see cref="Action{T}"/> if the predicate evaluates to true.
        /// The excution takes place when the object can be locked to prevent parallel processing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The obect to look.</param>
        /// <param name="predicate">This must evaluate to <c>true</c> for the action to be executed.</param>
        /// <param name="action">The action to be performed while the object ist locked.</param>
        public static void ExecuteLocked<T>(this T obj, Func<T, bool> predicate, Action<T> action)
        {
            if (predicate(obj)) // needs to be executed?
            {
                lock (obj) // lock
                {
                    if (predicate(obj)) // still needs to be executed?
                        action(obj);
                }
            }
        }
    }
}
