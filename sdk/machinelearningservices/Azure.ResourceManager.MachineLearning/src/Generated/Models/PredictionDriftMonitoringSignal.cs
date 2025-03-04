// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The PredictionDriftMonitoringSignal. </summary>
    public partial class PredictionDriftMonitoringSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="PredictionDriftMonitoringSignal"/>. </summary>
        /// <param name="metricThresholds">
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="PredictionDriftMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalPredictionDriftMetricThreshold"/> and <see cref="NumericalPredictionDriftMetricThreshold"/>.
        /// </param>
        /// <param name="modelType"> [Required] The type of the model monitored. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricThresholds"/>, <paramref name="productionData"/> or <paramref name="referenceData"/> is null. </exception>
        public PredictionDriftMonitoringSignal(IEnumerable<PredictionDriftMetricThresholdBase> metricThresholds, MonitoringModelType modelType, MonitoringInputDataBase productionData, MonitoringInputDataBase referenceData)
        {
            Argument.AssertNotNull(metricThresholds, nameof(metricThresholds));
            Argument.AssertNotNull(productionData, nameof(productionData));
            Argument.AssertNotNull(referenceData, nameof(referenceData));

            MetricThresholds = metricThresholds.ToList();
            ModelType = modelType;
            ProductionData = productionData;
            ReferenceData = referenceData;
            SignalType = MonitoringSignalType.PredictionDrift;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionDriftMonitoringSignal"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="metricThresholds">
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="PredictionDriftMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalPredictionDriftMetricThreshold"/> and <see cref="NumericalPredictionDriftMetricThreshold"/>.
        /// </param>
        /// <param name="modelType"> [Required] The type of the model monitored. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        internal PredictionDriftMonitoringSignal(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<PredictionDriftMetricThresholdBase> metricThresholds, MonitoringModelType modelType, MonitoringInputDataBase productionData, MonitoringInputDataBase referenceData) : base(mode, properties, signalType, serializedAdditionalRawData)
        {
            MetricThresholds = metricThresholds;
            ModelType = modelType;
            ProductionData = productionData;
            ReferenceData = referenceData;
            SignalType = signalType;
        }

        /// <summary> Initializes a new instance of <see cref="PredictionDriftMonitoringSignal"/> for deserialization. </summary>
        internal PredictionDriftMonitoringSignal()
        {
        }

        /// <summary>
        /// [Required] A list of metrics to calculate and their associated thresholds.
        /// Please note <see cref="PredictionDriftMetricThresholdBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CategoricalPredictionDriftMetricThreshold"/> and <see cref="NumericalPredictionDriftMetricThreshold"/>.
        /// </summary>
        public IList<PredictionDriftMetricThresholdBase> MetricThresholds { get; }
        /// <summary> [Required] The type of the model monitored. </summary>
        public MonitoringModelType ModelType { get; set; }
        /// <summary>
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ProductionData { get; set; }
        /// <summary>
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ReferenceData { get; set; }
    }
}
