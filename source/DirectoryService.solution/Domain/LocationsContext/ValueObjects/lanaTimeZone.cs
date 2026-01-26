using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.LocationsContext.ValueObjects
{
<<<<<<< HEAD
<<<<<<< HEAD
    public sealed class IanaTimeZone
    {
        public string Value { get; }

        private IanaTimeZone(string value)
=======
    public sealed class lanaTimeZone
    {
        public string Value { get; }

        private lanaTimeZone(string value)
>>>>>>> cf601eb (добавил модели)
=======
    public sealed class IanaTimeZone
    {
        public string Value { get; }

        private IanaTimeZone(string value)
>>>>>>> 3b70da4 (Сделал работу)
        {
            Value = value;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public static IanaTimeZone Create(string value)
=======
        public static lanaTimeZone Create(string value)
>>>>>>> cf601eb (добавил модели)
=======
        public static IanaTimeZone Create(string value)
>>>>>>> 3b70da4 (Сделал работу)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("IANA временная зона не может быть пустой.", nameof(value));

           
            if (!value.Contains('/'))
                throw new ArgumentException(
                    "Некорректный формат IANA временной зоны. Ожидается формат: Continent/City",
                    nameof(value));

            string[] parts = value.Split('/');

            if (parts.Length < 2)
                throw new ArgumentException(
                    "Некорректный формат IANA временной зоны. Ожидается формат: Continent/City",
                    nameof(value));

            
            foreach (var part in parts)
            {
                if (string.IsNullOrWhiteSpace(part))
                    throw new ArgumentException(
                        "Некорректный формат IANA временной зоны. Части не могут быть пустыми.",
                        nameof(value));
            }

<<<<<<< HEAD
<<<<<<< HEAD
            return new IanaTimeZone(value);
=======
            return new lanaTimeZone(value);
>>>>>>> cf601eb (добавил модели)
=======
            return new IanaTimeZone(value);
>>>>>>> 3b70da4 (Сделал работу)
        }
    }
}
    

