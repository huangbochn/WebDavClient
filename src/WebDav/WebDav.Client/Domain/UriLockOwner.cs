﻿using System;

namespace WebDav
{
    /// <summary>
    /// Represents a lock owner identified by URI.
    /// </summary>
    public class UriLockOwner : LockOwner
    {
        private readonly string _uri;

        /// <summary>
        /// Initializes a new instance of the <see cref="UriLockOwner"/> class.
        /// </summary>
        /// <param name="absoluteUri">The absolute URI.</param>
        /// <exception cref="System.ArgumentException">The parameter uri should be a valid absolute uri.;absoluteUri</exception>
        public UriLockOwner(string absoluteUri)
        {
            if (!Uri.IsWellFormedUriString(absoluteUri, UriKind.Absolute))
                throw new ArgumentException("The parameter uri should be a valid absolute uri.", "absoluteUri");
            _uri = absoluteUri;
        }

        /// <summary>
        /// Gets a value representing an owner.
        /// </summary>
        public override string Value
        {
            get { return _uri; }
        }
    }
}
