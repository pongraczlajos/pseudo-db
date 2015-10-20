using PseudoDb.Engine.Common;
using PseudoDb.Interfaces.Engine;
using PseudoDb.Interfaces.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace PseudoDb.Engine
{
    class DbEngine : IEngine
    {
        private IMetadata metadata;

        public DbEngine(IMetadata metadata)
        {
            this.metadata = metadata;
        }
    }
}
