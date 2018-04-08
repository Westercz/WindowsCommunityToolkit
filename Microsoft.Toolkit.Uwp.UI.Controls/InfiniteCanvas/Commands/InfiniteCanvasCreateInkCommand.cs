﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Collections.Generic;
using Windows.UI.Input.Inking;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    internal class InfiniteCanvasCreateInkCommand : IInfiniteCanvasCommand
    {
        private readonly List<IDrawable> _drawableList;
        private readonly InkDrawable _drawable;

        public InfiniteCanvasCreateInkCommand(List<IDrawable> drawableList, IReadOnlyList<InkStroke> strokes)
        {
            _drawable = new InkDrawable(strokes);
            _drawableList = drawableList;
        }

        public void Execute()
        {
            _drawableList.Add(_drawable);
        }

        public void UnExecute()
        {
            _drawableList.Remove(_drawable);
        }
    }
}
