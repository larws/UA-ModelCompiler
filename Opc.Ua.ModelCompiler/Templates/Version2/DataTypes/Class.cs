namespace X {
// ***START***
#region _BrowseName_ Class
#if (!OPCUA_EXCLUDE__BrowseName_)
/// <remarks />
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
[DataContract(Namespace = _XmlNamespaceUri_)]
public _IsAbstract_partial class _BrowseName_ : IEncodeable, IJsonEncodeable
{
    #region Fields

    private readonly ExpandedNodeId _typeId;
    private readonly ExpandedNodeId _binaryEncodingId;
    private readonly ExpandedNodeId _xmlEncodingId;
    private readonly ExpandedNodeId _jsonEncodingId;

    #endregion

    #region Constructors
    /// <remarks />
    public _BrowseName_() : this(
        DataTypeIds._BrowseName_, 
        ObjectIds._BrowseName__Encoding_DefaultBinary, 
        ObjectIds._BrowseName__Encoding_DefaultXml, 
        ObjectIds._BrowseName__Encoding_DefaultJson)
    {
    }

    /// <remarks />
    protected _BrowseName_(ExpandedNodeId typeId, ExpandedNodeId binaryEncodingId, ExpandedNodeId xmlEncodingId, ExpandedNodeId jsonEncodingId)
    {
        _typeId = typeId;
        _binaryEncodingId = binaryEncodingId;
        _xmlEncodingId = xmlEncodingId;
        _jsonEncodingId = jsonEncodingId;
        
        Initialize();
    }
        
    [OnDeserializing]
    private void Initialize(StreamingContext context)
    {
        Initialize();
    }
        
    private void Initialize()
    {
        // ListOfFieldInitializers
    }
    #endregion

    #region Public Properties
    // ListOfProperties
    #endregion

    #region IEncodeable Members
    /// <summary cref="IEncodeable.TypeId" />
    ExpandedNodeId IEncodeable.TypeId => _typeId; 

    /// <summary cref="IEncodeable.BinaryEncodingId" />
    ExpandedNodeId IEncodeable.BinaryEncodingId => _binaryEncodingId;

    /// <summary cref="IEncodeable.XmlEncodingId" />
    ExpandedNodeId IEncodeable.XmlEncodingId => _xmlEncodingId;
                
    /// <summary cref="IJsonEncodeable.JsonEncodingId" />
    ExpandedNodeId IJsonEncodeable.JsonEncodingId => _jsonEncodingId;

    /// <summary cref="IEncodeable.Encode(IEncoder)" />
    void IEncodeable.Encode(IEncoder encoder)
    {
        encoder.PushNamespace(_XmlNamespaceUri_);

        OnWriteEncodingMask(encoder);
        OnEncodeFields(encoder);

        encoder.PopNamespace();
    }

    protected virtual void OnWriteEncodingMask(IEncoder encoder) { }

    protected virtual void OnEncodeFields(IEncoder encoder)
    {
        // ListOfEncodedFields
    }

    /// <summary cref="IEncodeable.Decode(IDecoder)" />
    void IEncodeable.Decode(IDecoder decoder)
    {
        decoder.PushNamespace(_XmlNamespaceUri_);

        OnReadEncodingMask(decoder);
        OnDecodeFields(decoder);

        decoder.PopNamespace();
    }

    protected virtual void OnReadEncodingMask(IDecoder decoder) { }

    protected virtual void OnDecodeFields(IDecoder decoder)
    {
        // ListOfDecodedFields
    }

    /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
    public virtual bool IsEqual(IEncodeable encodeable)
    {
        if (Object.ReferenceEquals(this, encodeable))
        {
            return true;
        }

        _BrowseName_ value = encodeable as _BrowseName_;

        if (value == null)
        {
            return false;
        }

        // ListOfComparedFields

        return true;
    }

    /// <summary cref="ICloneable.Clone" />
    public virtual object Clone()
    {
        return (_BrowseName_)this.MemberwiseClone();
    }

    /// <summary cref="Object.MemberwiseClone" />
    public new object MemberwiseClone()
    {
        _BrowseName_ clone = (_BrowseName_)base.MemberwiseClone();

        // ListOfClonedFields

        return clone;
    }
    #endregion

    #region Private Fields
    // ListOfFields
    #endregion
}
// CollectionClass
#endif
#endregion
// ***END***
}