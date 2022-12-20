using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
	public class Cart
	{
		public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Product product, int quantitiy)
        {
            CartLine line = Lines
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine { Product = product, Quantity = quantitiy });
            }
            else
            {
                line.Quantity += quantitiy;
            }
        }

        public virtual void RemoveLine(Product product) =>
            Lines.RemoveAll(ctx => ctx.Product.ProductID == product.ProductID);
        public decimal ComputeTotalValue() =>
            Lines.Sum(ctx => ctx.Product.Price * ctx.Quantity);
        public virtual void Clear() =>
            Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

}

