/*
 * Copyright (c) InWorldz Halcyon Developers
 * Copyright (c) Contributors, http://opensimulator.org/
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using OpenMetaverse;

namespace OpenSim.Framework
{
    public class LandUpdateArgs : EventArgs
    {
        public UUID AuthBuyerID;
        public ParcelCategory Category;
        public string Desc;
        public UUID GroupID;
        public byte LandingType;
        public byte MediaAutoScale;
        public UUID MediaID;
        public string MediaURL;
        public string MusicURL;
        public string Name;
        public uint ParcelFlags;
        public float PassHours;
        public int PassPrice;
        public int SalePrice;
        public UUID SnapshotID;
        public Vector3 UserLocation;
        public Vector3 UserLookAt;
        public string MediaType;
        public string MediaDescription;
        public int MediaHeight;
        public int MediaWidth;
        public bool MediaLoop;
        public bool ObscureMusic;
        public bool ObscureMedia;

        public bool _hasParcelLimitData;
        // Added together in newer parcel limit data fields
        public bool SeeAvs;
        public bool AnyAvSounds;
        public bool GroupAvSounds;
    }
}
