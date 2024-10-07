using System.ComponentModel;
using test.api.domain;

namespace test.api.model 
{
    public class ProductModel : IModel
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string CategoryName {get; set;}

        public int CategoryId {get; set;}

    }
}

