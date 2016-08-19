// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollector.InProcDataCollector
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

    /// <summary>
    /// The test case end args.
    /// </summary>
    public class TestCaseEndArgs : InProcDataCollectionArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseEndArgs"/> class.
        /// </summary>
        /// <param name="dataCollectionContext">
        /// The data Collection Context.
        /// </param>
        /// <param name="outcome">
        /// The outcome.
        /// </param>
        public TestCaseEndArgs(DataCollectionContext dataCollectionContext, TestOutcome outcome)
        {
            this.TestOutcome = outcome;
            this.DataCollectionContext = dataCollectionContext;
        }

        /// <summary>
        /// Gets the outcome.
        /// </summary>
        public TestOutcome TestOutcome { get; private set; }

        /// <summary>
        /// Gets the data collection context.
        /// </summary>
        public DataCollectionContext DataCollectionContext { get; private set; }
    }
}
