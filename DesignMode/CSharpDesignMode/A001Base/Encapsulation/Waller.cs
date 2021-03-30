using System;

namespace A001Base.Encapsulation
{
    /// <summary>
    /// 钱包 - 封装
    /// </summary>
    public class Waller
    {
        /// <summary>
        /// 唯一主键id
        /// </summary>
        public string Id { get; } = Guid.NewGuid().ToString();

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; }= DateTime.Now.ToFileTimeUtc();

        /// <summary>
        /// 钱包余额
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// 上次钱包更新的时间
        /// </summary>
        public long BalanceLastModifiedTime { get; private set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="increasedAmount">存入额度</param>
        public void IncreaseBalance(decimal increasedAmount)
        {
            if (increasedAmount < 0)
            {
                throw new Exception($"传入值 increasedAmount：{increasedAmount}，小于0。");
            }

            Balance += increasedAmount;
            BalanceLastModifiedTime = DateTime.Now.ToFileTimeUtc();
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="decreasedAmount">取出金额</param>
        public void DecreaseBalance(decimal decreasedAmount)
        {
            if (decreasedAmount < 0)
            {
                throw new Exception($"传入值 decreasedAmount：{decreasedAmount}，小于0。");
            }

            if (decreasedAmount - Balance > 0)
            {
                throw new Exception($"传入值 decreasedAmount：{decreasedAmount}，比现存金额大。");
            }

            Balance -= decreasedAmount;
            BalanceLastModifiedTime = DateTime.Now.ToFileTimeUtc();
        }
    }
}