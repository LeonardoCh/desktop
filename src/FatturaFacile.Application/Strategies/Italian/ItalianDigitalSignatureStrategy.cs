// <copyright file="ItalianInvoicingStrategy.cs" company="Fattura Facile">
// Copyright (c) Fattura Facile. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using FatturaFacile.Domain.Entities;

using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;

namespace FatturaFacile.Application.Strategies.Italian;

/// <summary>
/// Italian invoicing strategy: validates the data and generates the FatturaPA XML file ready for transmission to the
/// Sistema di Interscambio (SDI). Transmission itself (via an accredited intermediary, web service or PEC) is a separate step.
/// </summary>
public sealed class ItalianDigitalSignStrategy
{

    /// <summary>
    /// Invoke XSLT transformation to insert the Digital Signature tags in the final XML invoice
    /// </summary>
    public void SetDigitalSign = 
    {
        var assembly = Assembly.GetExecutingAssembly();

	string resourceName = "FatturaFacile.Application.Strategies.Italian.Resources/DigitalSignItaXsltTransformation.xslt";

    	using Stream stream = assembly.GetManifestResourceStream(resourceName) 
                          ?? throw new FileNotFoundException($"Risorsa XSLT non trovata: {resourceName}");

    	using XmlReader xmlReader = XmlReader.Create(stream);

    	XslCompiledTransform xslt = new XslCompiledTransform();
    	xslt.Load(xmlReader);
    }

    /// <summary>
    /// Gets or sets the primary key identifier.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the optional owning tenant identifier. If null, the product is a global template.
    /// </summary>
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Gets or sets the unique product SKU code.
    /// </summary>
    public string Sku { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the display name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the selling price.
    /// </summary>
    public decimal SalePrice { get; set; }
}
