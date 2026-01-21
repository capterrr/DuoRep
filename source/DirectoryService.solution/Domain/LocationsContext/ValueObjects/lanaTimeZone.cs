using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.LocationsContext.ValueObjects
{
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
        {
            Value = value;
        }

<<<<<<< HEAD
        public static IanaTimeZone Create(string value)
=======
        public static lanaTimeZone Create(string value)
>>>>>>> cf601eb (добавил модели)
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
            return new IanaTimeZone(value);
=======
            return new lanaTimeZone(value);
>>>>>>> cf601eb (добавил модели)
        }
    }
}
    

