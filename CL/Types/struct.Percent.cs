////////////////using System.Diagnostics;

////////////////namespace CoViD.Types
////////////////{
////////////////    /// <summary>
////////////////    /// 
////////////////    /// </summary>
////////////////    public struct Percent
////////////////    {
////////////////        /// <summary>
////////////////        /// Float representation of the value (It's a number <= 1).
////////////////        /// </summary>
////////////////        public readonly float Value;

////////////////        /// <summary>
////////////////        /// Main Constructor.
////////////////        /// </summary>
////////////////        /// <param name="value">Il tipo della sede in formato stringa.</param>
////////////////        public Percent(float value)
////////////////        {
////////////////            this.Value = value;
////////////////        }

////////////////        public override string ToString()
////////////////        {
////////////////            return Vi.Tools.Utilities.Join(this.Value);
////////////////        }

////////////////        #region Operatori impliciti
////////////////        /// <summary>
////////////////        /// 'Casts' the struct to its original type.
////////////////        /// </summary>
////////////////        /// <param name="percent">An instance of 'Percent'.</param>
////////////////        [DebuggerStepThrough]
////////////////        public static implicit operator float(Percent percent)
////////////////        {
////////////////            return percent.Value;
////////////////        }

////////////////        /// <summary>
////////////////        /// 
////////////////        /// </summary>
////////////////        /// <param name="value">The built in typy to cast to Percent.</param>
////////////////        [DebuggerStepThrough]
////////////////        public static implicit operator Percent(float value)
////////////////        {
////////////////            return new Percent(value);
////////////////        }
////////////////        #endregion


////////////////    }
////////////////}

