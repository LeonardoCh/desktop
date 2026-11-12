// <copyright file="ItalianInvoicingStrategy.cs" company="Fattura Facile">
// Copyright (c) Fattura Facile. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using FatturaFacile.Domain.Entities;

namespace FatturaFacile.Application.Strategies.Italian;

/// <summary>
/// Italian invoicing strategy: validates the data and generates the FatturaPA XML file ready for transmission to the
/// Sistema di Interscambio (SDI). Transmission itself (via an accredited intermediary, web service or PEC) is a separate step.
/// </summary>
public sealed class ItalianDigitalSignStrategy : ICountryInvoicingStrategy
{

}
