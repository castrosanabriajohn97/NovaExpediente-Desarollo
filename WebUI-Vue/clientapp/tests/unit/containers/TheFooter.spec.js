/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Vue from 'vue'
import CoreuiVue from '@coreui/vue'
import TheFooter from '@/containers/TheFooter'
import { shallowMount } from '@vue/test-utils';

Vue.use(CoreuiVue)

describe('TheFooter.vue', () => {

  test('renders correctly', () => {
    const wrapper = shallowMount(TheFooter)
    expect(wrapper.element).toMatchSnapshot()
  })
})