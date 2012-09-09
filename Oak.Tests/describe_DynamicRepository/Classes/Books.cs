using System;
using System.Collections.Generic;
using System.Linq;
using Massive;

namespace Oak.Tests.describe_DynamicRepository.Classes
{
    public class Books : DynamicRepository
    {
        public Books()
        {
            Projection = d => new Book(d);
        }
    }
}
