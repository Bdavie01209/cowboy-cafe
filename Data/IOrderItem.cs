/*

* Author: Blake Davies

* File name: IorderItem.cs

* Purpose: to be the absolute minimum that a orderable item will contain

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// interface that all orderable items will inherite from
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// price of the given item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// speial instructions for said item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
