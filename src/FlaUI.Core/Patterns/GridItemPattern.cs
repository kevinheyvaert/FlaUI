﻿using FlaUI.Core.AutomationElements.Infrastructure;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns.Infrastructure;

namespace FlaUI.Core.Patterns
{
    public interface IGridItemPattern : IPattern
    {
        IGridItemPatternProperties Properties { get; }

        AutomationProperty<int> Column { get; }
        AutomationProperty<int> ColumnSpan { get; }
        AutomationProperty<AutomationElement> ContainingGrid { get; }
        AutomationProperty<int> Row { get; }
        AutomationProperty<int> RowSpan { get; }
    }

    public interface IGridItemPatternProperties
    {
        PropertyId ColumnProperty { get; }
        PropertyId ColumnSpanProperty { get; }
        PropertyId ContainingGridProperty { get; }
        PropertyId RowProperty { get; }
        PropertyId RowSpanProperty { get; }
    }

    public abstract class GridItemPatternBase<TNativePattern> : PatternBase<TNativePattern>, IGridItemPattern
    {
        protected GridItemPatternBase(BasicAutomationElementBase basicAutomationElement, TNativePattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
            Column = new AutomationProperty<int>(() => Properties.ColumnProperty, BasicAutomationElement);
            ColumnSpan = new AutomationProperty<int>(() => Properties.ColumnSpanProperty, BasicAutomationElement);
            ContainingGrid = new AutomationProperty<AutomationElement>(() => Properties.ContainingGridProperty, BasicAutomationElement);
            Row = new AutomationProperty<int>(() => Properties.RowProperty, BasicAutomationElement);
            RowSpan = new AutomationProperty<int>(() => Properties.RowSpanProperty, BasicAutomationElement);
        }

        public IGridItemPatternProperties Properties => Automation.PropertyLibrary.GridItem;

        public AutomationProperty<int> Column { get; }
        public AutomationProperty<int> ColumnSpan { get; }
        public AutomationProperty<AutomationElement> ContainingGrid { get; }
        public AutomationProperty<int> Row { get; }
        public AutomationProperty<int> RowSpan { get; }
    }
}
