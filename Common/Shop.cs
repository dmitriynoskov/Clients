//Clients
//by Dmitriy Noskov
//2016-2017
//Библиотека с перечислениями магазинов и фильтров

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Список доступных магазинов
    /// </summary>
    public enum Shops
    {
        Karavan,
        Dafi,
        FourG,
        Kiev,
        Odessa,
        Bars,
        Outlet
    }

    /// <summary>
    /// Список действий при фильтрации
    /// </summary>
    public enum Filter
    {
        ALL,
        FILTERED
    }
}
