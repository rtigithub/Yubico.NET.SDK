// Copyright 2022 Yubico AB
//
// Licensed under the Apache License, Version 2.0 (the "License").
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Yubico.YubiKey.Sample.Fido2SampleCode
{
    public enum Fido2MainMenuItem
    {
        ListYubiKeys = 0,
        ChooseYubiKey = 1,
        SetPin = 4,
        ChangePin = 5,
        VerifyPin = 6,

        MakeCredential = 10,
        GetAssertion = 11,

        Reset = 20,

        Exit = 24,
    }
}
