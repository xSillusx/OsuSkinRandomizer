﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SkinRandomizer.ViewModels
{
    /// <summary>
    ///  the binding base of the ui, inherints from the BaseViewModel so it can trigger the event changed
    /// </summary>
    public class ViewModel : BaseViewModel
    {
        private string version = "2.1";
        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                base.OnPropertyChanged(nameof(Version));
            }
        }

        private string _windowTitle = "OsuSkinRandomizer v";
        public string WindowTitle
        {
            get 
            { 
                return _windowTitle + version;
            }
            set 
            {
                _windowTitle = value;
                base.OnPropertyChanged(nameof(WindowTitle));
            }
        }

        private bool _isSkinFolderFound = false;
        public bool IsSkinFolderFound
        {
            get
            {
                return _isSkinFolderFound;
            }
            set
            {
                _isSkinFolderFound = value;
                base.OnPropertyChanged(nameof(IsSkinFolderFound));
            }
        }

        private string _osuFolder = "";
        public string OsuFolder
        {
            get
            {
                return _osuFolder;
            }
            set
            {
                _osuFolder = value;
                base.OnPropertyChanged(nameof(OsuFolder));
            }
        }

        private bool _isNormalRandomMode = true;
        public bool IsNormalRandomMode
        {
            get
            {
                return _isNormalRandomMode;
            }
            set
            {
                _isNormalRandomMode = value;

                if(_isNormalRandomMode == true)
                {
                    IsCorruptionMode = false;
                }

                base.OnPropertyChanged(nameof(IsNormalRandomMode));
            }
        }

        private bool _isCorruptionMode = false;
        public bool IsCorruptionMode
        {
            get
            {
                return _isCorruptionMode;
            }
            set
            {
                _isCorruptionMode = value;

                if(_isCorruptionMode == true)
                {
                    IsNormalRandomMode = false;
                }

                base.OnPropertyChanged(nameof(IsCorruptionMode));
            }
        }

        private string _creationName = "EpicRandomSkin";
        public string CreationName
        {
            get
            {
                return _creationName;
            }
            set
            {
                _creationName = value;
                base.OnPropertyChanged(nameof(CreationName));
            }
        }

        private BitmapImage _imagePreview;
        public BitmapImage ImagePreview
        {
            get
            {
                return _imagePreview;
            }
            set
            {
                _imagePreview = value;
                base.OnPropertyChanged(nameof(ImagePreview));
            }
        }
    }
}
