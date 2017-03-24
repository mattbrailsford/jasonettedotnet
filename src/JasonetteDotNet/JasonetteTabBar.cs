using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace JasonetteDotNet
{
    public class JasonetteTabBar : JasonetteEntity, IList<JasonetteTab>
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<JasonetteTab> Items { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Style { get; set; }

        public JasonetteTabBar()
            : this(Enumerable.Empty<JasonetteTab>())
        { }

        public JasonetteTabBar(IEnumerable<JasonetteTab> tabs)
        {
            this.Items = new List<JasonetteTab>(tabs);
            this.Style = new Dictionary<string, object>();
        }

        public bool ShouldSerializeItems()
        {
            return !this.Items.IsNullOrEmpty();
        }

        public bool ShouldSerializeStyle()
        {
            return !this.Style.IsNullOrEmpty();
        }

        public static implicit operator JasonetteTabBar(JasonetteTab[] tabs)
        {
            return new JasonetteTabBar(tabs);
        }

        #region IList<JasonetteTab>

        public IEnumerator<JasonetteTab> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(JasonetteTab item)
        {
            this.Items.Add(item);
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public bool Contains(JasonetteTab item)
        {
            return this.Items.Contains(item);
        }

        public void CopyTo(JasonetteTab[] array, int arrayIndex)
        {
            this.Items.CopyTo(array, arrayIndex);
        }

        public bool Remove(JasonetteTab item)
        {
            return this.Items.Remove(item);
        }

        public int Count => Items.Count;

        public bool IsReadOnly => false;

        public int IndexOf(JasonetteTab item)
        {
            return this.Items.IndexOf(item);
        }

        public void Insert(int index, JasonetteTab item)
        {
            this.Items.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.Items.RemoveAt(index);
        }

        public JasonetteTab this[int index]
        {
            get
            {
                return this.Items[index];
            }
            set
            {
                this.Items[index] = value;
            }
        }

        #endregion
    }
}