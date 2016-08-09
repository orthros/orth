using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orth.core.Extensions
{
    public static class FluentExtensions
    {
        /// <summary>
        /// Performs the given action for each item in the sequence.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">Sequence of items being operated on.</param>
        /// <param name="action">The action to be performed.</param>
        /// <returns>The original sequence.</returns>
        public static IEnumerable<T> Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
            {
                T capturedItem = item; // Necessary to prevent captured variable bug.
                action(capturedItem);
            }

            return items;
        }

        /// <summary>
        /// Performs the given action for each item in the list.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">List of items being operated on.</param>
        /// <param name="action">The action to be performed.</param>
        /// <returns>The original sequence.</returns>
        public static IList<T> Each<T>(this IList<T> items, Action<T> action)
        {

            for (int i = 0; i < items.Count; i++)
            {
                T capturedItem = items[i]; // Necessary to prevent captured variable bug.
                action(capturedItem);
            }

            return items;
        }

        /// <summary>
        /// Performs the given action for each item in the array.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">Array of items being operated on.</param>
        /// <param name="action">The action to be performed.</param>
        /// <returns>The original sequence.</returns>
        public static T[] Each<T>(this T[] items, Action<T> action)
        {

            for (int i = 0; i < items.Length; i++)
            {
                T capturedItem = items[i]; // Necessary to prevent captured variable bug.
                action(capturedItem);
            }

            return items;
        }

        /// <summary>
        /// Performs the given action for each item in the sequence.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">Sequence of items being operated on.</param>
        /// <param name="action">The action to be performed, which may also use the index variable.</param>
        /// <returns>The original sequence.</returns>
        public static IEnumerable<T> Each<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            int i = 0;
            foreach (T item in items)
            {
                T capturedItem = item; // Necessary to prevent captured variable bug.
                action(capturedItem, i++);
            }

            return items;
        }

        /// <summary>
        /// Performs the given action for each item in the list.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">List of items being operated on.</param>
        /// <param name="action">The action to be performed, which may also use the index variable.</param>
        /// <returns>The original sequence.</returns>
        public static IList<T> Each<T>(this IList<T> items, Action<T, int> action)
        {

            for (int i = 0; i < items.Count; i++)
            {
                T capturedItem = items[i]; // Necessary to prevent captured variable bug.
                action(capturedItem, i);
            }

            return items;
        }

        /// <summary>
        /// Performs the given action for each item in the array.
        /// </summary>
        /// <typeparam name="T">Type of item being iterated on.</typeparam>
        /// <param name="items">Array of items being operated on.</param>
        /// <param name="action">The action to be performed, which may also use the index variable.</param>
        /// <returns>The original sequence.</returns>
        public static T[] Each<T>(this T[] items, Action<T, int> action)
        {

            for (int i = 0; i < items.Length; i++)
            {
                T capturedItem = items[i]; // Necessary to prevent captured variable bug.
                action(capturedItem, i);
            }

            return items;
        }

    }
}
