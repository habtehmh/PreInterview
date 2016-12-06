using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{

    #region "Offer Class"
    public class Offer
    {
        public static decimal CalculateOfferPrice(List<Item> items)
        {
            decimal _offerPrice = 0;
            _offerPrice += OrangeOfferPrice(items);
            _offerPrice += AppelOfferPrice(items);
            return _offerPrice;
        }
        public static decimal OrangeOfferPrice(List<Item> items)
        {
            Orange _ornage = new Orange();
            decimal _salePrice = 0;
            _ornage.GetQuantity(items);
            int _itemsRemain = 0;
            for (int i = 1; i <= _ornage.Quantity; i += 3)
            {

                if (i == 1 && _itemsRemain == 0 && _ornage.Quantity > 2)
                {
                    _salePrice += _ornage.UnitPrice * 2;
                    _itemsRemain = _ornage.Quantity - 3;
                }
                else
                {
                    if (_itemsRemain % 3 != 0)
                    {
                        _salePrice += _ornage.UnitPrice * (_itemsRemain % 3);
                    }
                    else
                    {
                        _salePrice += _ornage.UnitPrice * 2;
                    }

                    _itemsRemain = _ornage.Quantity - i;
                }

            }
            return _salePrice;
        }
        public static decimal AppelOfferPrice(List<Item> items)
        {
            Apple _apple = new Apple();
            decimal _salePrice = 0;
            _apple.GetQuantity(items);
            for (int i = 1; i <= _apple.Quantity; i += 2)
            {
                _salePrice += _apple.UnitPrice;
            }
            return _salePrice;
        }
    }
    #endregion

}
