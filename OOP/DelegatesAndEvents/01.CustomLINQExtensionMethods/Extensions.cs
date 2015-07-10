namespace _01.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            List<T> result = new List<T>();

            foreach (var element in collection)
            {
                if (!condition(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector MaxItem<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> selected) where TSelector : IComparable<TSelector>
        {
            if (collection.Count() == 0)
            {
                return default(TSelector);
            }

            List<TSource> list = collection.ToList();

            if (list.Count == 1)
            {
                return selected(list[0]);
            }

            TSelector result = selected(list[0]);

            foreach (var element in list)
            {
                if (result.CompareTo(selected(element)) == -1)
                {
                    result = selected(element);
                }
            }

            return result;
        }
    }
}
