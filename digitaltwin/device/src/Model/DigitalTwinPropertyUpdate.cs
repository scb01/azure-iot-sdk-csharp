﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Azure.Iot.DigitalTwin.Device.Model
{
    /// <summary>
    /// Contains information of the property update request passed from the Digital Twin Client to Digital Twin Interface Client
    /// for further processing.
    /// </summary>
    public struct DigitalTwinPropertyUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalTwinPropertyUpdate"/> struct.
        /// </summary>
        /// <param name="respondVersion">The response version.</param>
        /// <param name="statusCode">The status code which maps to appropriate HTTP status code of the property updates.</param>
        /// <param name="statusDescription">Friendly description string of current status of update.</param>
        internal DigitalTwinPropertyUpdate(string propertyName, int desiredVersion, string propertyDesired, string propertyReported)
        {
            this.PropertyName = propertyName;
            this.DesiredVersion = desiredVersion;
            this.PropertyDesired = propertyDesired;
            this.PropertyReported = propertyReported;
        }

        /// <summary>
        /// Gets the name of the property being update.
        /// </summary>
        public string PropertyName
        {
            get; private set;
        }

        /// <summary>
        /// Gets the value which the device application had previously reported for this property.
        /// This value may be NULL if the application never reported the property.  It will also
        /// be NULL when an update arrives to the given property after the initial callback.
        /// </summary>
        public string PropertyReported
        {
            get; private set;
        }

        /// <summary>
        /// Gets the value of the service requests the given property to be set to.
        /// </summary>
        public string PropertyDesired
        {
            get; private set;
        }

        /// <summary>
        /// Gets the version of this property.
        /// </summary>
        public int DesiredVersion
        {
            get; private set;
        }
    }
}
