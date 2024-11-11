using System.ComponentModel;

namespace dataGridView.Contracts.Models
{
    /// <summary>
    /// Направление
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Турция
        /// </summary>
        [Description("Турция")]
        Turkish = 1,

        /// <summary>
        /// Испания
        /// </summary>
        [Description("Испания")]
        Spain = 2,

        /// <summary>
        /// Италия
        /// </summary>
        [Description("Италия")]
        Italy = 3,

        /// <summary>
        /// Франция
        /// </summary>
        [Description("Франция")]
        France = 4,

        /// <summary>
        /// Шушары
        /// </summary>
        [Description("Шушары")]
        Shushary = 5,
    }
}
